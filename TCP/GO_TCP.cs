using FakeBarcodePDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeDoor
{
    public class GO_TCP
    {
        private List<TcpClient> goTcpClient;

        private List<TcpListener> goTcpListener;

        private List<GO_TCP_IPORT> list_iport = new List<GO_TCP_IPORT>();

        /// <summary>
        /// 設定IP&Port
        /// </summary>
        /// <param name="_s"></param>
        /// <returns>無誤回傳空字串，錯誤回傳ErrorCode。</returns>
        public string GoSetIpPort(string[] _s) {
            List<int> port_index = new List<int>();

            try
            {
                foreach (string one_ipport in _s)
                {
                    string[] s_iport = one_ipport.Split(':');

                    string s_ip = s_iport[0];
                    int i_port = int.Parse(s_iport[1]);

                    int index = port_index.IndexOf(i_port);
                    if (index == -1)
                    {
                        port_index.Add(i_port);
                        list_iport.Add(new GO_TCP_IPORT() { go_port = i_port }.Go_AddIP(s_ip));
                    }
                    else
                    {
                        list_iport[index].Go_AddIP(s_ip);
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "Good";
        }

        /// <summary>
        /// 啟動TCP_GO
        /// </summary> 
        /// <returns>是否完成</returns>
        public bool GoConnact() {

            try
            {
                foreach (GO_TCP_IPORT go_tcp in list_iport)
                {
                    TcpClient _tcpClient = new TcpClient();
                    _tcpClient.ConnectAsync(go_tcp.go_ip, go_tcp.go_port);

                    goTcpClient.Add(_tcpClient);

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 關閉TCP_GO
        /// </summary>
        /// <returns>是否完成</returns>
        public bool GoDisConnact() {

            try
            {
                foreach (TcpClient _tcp in goTcpClient)
                {
                    _tcp.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 開啟TCP Server
        /// </summary>
        /// <param name="_port">Server Port</param>
        /// <returns>是否成功開啟</returns>
        public bool GoOpenServer(int _port) {
            try
            {
                TcpListener tcp_server = new TcpListener(_port);
                tcp_server.Start();
                goTcpListener.Add(tcp_server);
                Thread server_thread = new Thread(new ThreadStart()); 
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 關閉TCP Server
        /// </summary>
        /// <returns>是否成功關閉</returns>
        public bool GoCloseServer() {
            try
            {
                foreach (TcpListener _server in goTcpListener)
                {
                    _server.Stop();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 當TCP_GO收到資料時
        /// </summary>
        /// <param name="get_message_method"></param>
        public void GoMessageGet(Delegate get_message_method) {
            //TODO

        }

    }
}

using FakeBarcodePDA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeDoor
{
    public class GO_TCP
    {
        private List<TcpClient> goTcpClient = new List<TcpClient>();

        private List<TcpListener> goTcpListener = new List<TcpListener>();

        private List<GO_TCP_IPORT> list_iport = new List<GO_TCP_IPORT>();

        private delegate void go_listen_message_event(string s);
        private event go_listen_message_event Listen_message_event;

        /// <summary>
        /// 設定IP&Port
        /// </summary>
        /// <param name="_s"></param>
        /// <returns>無誤回傳空字串，錯誤回傳ErrorCode。</returns>
        public string GoSetIpPort(string[] _s) {
            List<int> port_index = new List<int>(); //計數器(port)所在陣列。
            list_iport.Clear();

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
            if (list_iport.Count < 1)
                return false;

            try
            {
                foreach (GO_TCP_IPORT go_tcp in list_iport)
                {
                    TcpClient _tcpClient = new TcpClient();
                    _tcpClient.Connect(go_tcp.go_ip, go_tcp.go_port);
                    if (_tcpClient.Connected)
                    {
                        //NetworkStream nws = _tcpClient.GetStream();

                        //byte[] write_buffer = Encoding.ASCII.GetBytes("A123B456");
                        //nws.Write(write_buffer, 0, write_buffer.Length);
                    }
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
            if (goTcpClient == null)
                return false;

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
        /// 送出輸入的訊息給所有已連接TCP_Client
        /// </summary>
        /// <param name="_text">訊息</param>
        /// <returns>成功數</returns>
        public int GoSend(string _text) 
        {
            int success = 0;

            try
            {
                foreach (TcpClient _tcp_client in goTcpClient)
                {
                    NetworkStream nws = _tcp_client.GetStream();
                    byte[] write_buffer = Encoding.ASCII.GetBytes(_text);
                    nws.Write(write_buffer,0, write_buffer.Length);

                    byte[] Write_buffer = new byte[256];
                    Int32 bytes = nws.Read(Write_buffer, 0, Write_buffer.Length);
                    String responseData = responseData = System.Text.Encoding.ASCII.GetString(Write_buffer, 0, bytes);
                    nws.Close();
                    success += 1;
               }
            }
            catch (Exception ex)
            {

            }
            
            return success;
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
                Thread server_thread = new Thread(new ParameterizedThreadStart(GoListener));
                server_thread.Start(tcp_server);
                goTcpListener.Add(tcp_server);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// TCP_Server_開啟
        /// </summary>
        /// <param name="_tcplistener"></param>
        private void GoListener(Object _tcplistener) {
            TcpListener tcplistener = (TcpListener)_tcplistener;
            tcplistener.Start();
            while (true)
            {
                NetworkStream ns = tcplistener.AcceptTcpClient().GetStream();
                //ns.ReadTimeout = 6000;
                //ns.WriteTimeout = 6000;
                byte[] Read_buffer = new byte[256];
                string getmessage = "";
                int i = 0;

                while ((i = ns.Read(Read_buffer, 0, Read_buffer.Length)) != 0)
                {
                    getmessage = System.Text.Encoding.ASCII.GetString(Read_buffer, 0, i);
                    Console.WriteLine("{0}", getmessage);
                }

                if(getmessage.Length > 0)
                {
                    Listen_message_event.Invoke(getmessage);
                }
            }
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
        /// 當TCP_GO收到資料時，執行傳入方法。
        /// </summary>
        /// <param name="get_message_method">傳入方法</param>
        /// <param name="input">傳入參數，第一個必須為字串</param>
        public void GoSetMessageGetEvent(Action<string> get_message_method) {
            Listen_message_event += new go_listen_message_event(get_message_method);
        }
    }
}

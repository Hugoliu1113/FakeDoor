using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FakeDoor
{
    public class TCP_GO
    {
        private List<TcpClient> goTcpClient;

        private List<TcpListener> goTcpListener;

        /// <summary>
        /// 設定IP&Port
        /// </summary>
        /// <param name="_s"></param>
        /// <returns>無誤回傳空字串，錯誤回傳ErrorCode。</returns>
        public string GoSetIpPort(string[] _s) {

            //TODO

            return "";
        }

        /// <summary>
        /// 啟動TCP_GO
        /// </summary>
        /// <returns>是否完成</returns>
        public bool GoStart() {

            //TODO

            return true;
        }

        /// <summary>
        /// 關閉TCP_GO
        /// </summary>
        /// <returns>是否完成</returns>
        public bool GoStop() {

            //TODO

            return true;
        }

        /// <summary>
        /// 當TCP_GO收到資料時
        /// </summary>
        /// <param name="GetMessageMethod"></param>
        public void GoMessageGet(Delegate GetMessageMethod) {
            //TODO
        }

    }
}

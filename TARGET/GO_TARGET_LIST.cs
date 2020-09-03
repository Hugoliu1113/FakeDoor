using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDoor
{
    public class GO_TARGET_LIST {

        private List<GO_IP_PORT> _ip_port_list = new List<GO_IP_PORT>();
        
        public GO_IP_PORT this[int _index]
        {
            get
            {
                return _ip_port_list[_index];
            }

            set
            {
                _ip_port_list[_index] = value;
            }
        }

        #region Method GoAdd
        /// <summary>
        /// 新增IP&Port進入表
        /// </summary>
        /// <param name="_ip_port">Class GO_IP_PORT</param>
        public void GoAdd(GO_IP_PORT _ip_port) {
            if (GoIsUnique(_ip_port))
            {
                _ip_port_list.Add(_ip_port);
            }
            else
            {
                //TODO
            }
        }

        /// <summary>
        /// 新增IP&Port進入表
        /// </summary>
        /// <param name="_ip">IP</param>
        /// <param name="_port">Port</param>
        public void GoAdd(string _ip, string _port) {
            //導向GoAdd最初的多載
            GoAdd(new GO_IP_PORT { ip = _ip, port = _port });
        } 
        #endregion

        #region Method GoRemove
        /// <summary>
        /// 刪除指定索引的Item
        /// </summary>
        /// <param name="_index"></param>
        public void GoRemove(int _index) {
            _ip_port_list.RemoveAt(_index);
        }

        /// <summary>
        /// 刪除列表中，傳入GO_IP_PORT物件
        /// </summary>
        /// <param name="_ip_port">GO_IP_PORT物件</param>
        public void GoRemove(GO_IP_PORT _ip_port) {
            int _count = _ip_port_list.Count;
            int i;

            string[] _s = new string[_count];
            for (i = 0; i < _count; i++)
            {
                if (_ip_port_list[i].ip == _ip_port.ip && _ip_port_list[i].ip == _ip_port.ip)
                    break;
            }

            GoRemove(i);
        }

        /// <summary>
        /// 刪除列表中，傳入IP & Port字串
        /// </summary>
        /// <param name="_ip">IP</param>
        /// <param name="_port">Port</param>
        public void GoRemove(string _ip, string _port) {
            GoRemove(new GO_IP_PORT { ip = _ip, port = _port });
        }
        #endregion

        #region //好像用不到
        /// <summary>
        /// 更改指定欄位之數值
        /// </summary>
        /// <param name="_index">更改欄位</param>
        /// <param name="_ip_port">更改後數值</param>
        public void GoChange(int _index, GO_IP_PORT _ip_port) {
            if (GoIsUnique(_ip_port))
            {
                _ip_port_list[_index] = _ip_port;
            }
        }

        public void GoChange(int _index, string _ip, string _port) {
            GoChange(_index, new GO_IP_PORT { ip = _ip, port = _port });
        }
        #endregion

        /// <summary>
        /// 將List賦蓋目前物件
        /// </summary>
        /// <param name="_list">GO_TARGET_LIST 實例</param>
        public void GoSetList(GO_TARGET_LIST _list) {
            _ip_port_list = _list._ip_port_list;
        }

        /// <summary>
        /// 深複製GO_TARGET_LIST物件
        /// </summary>
        /// <returns>GO_TARGET_LIST物件</returns>
        public GO_TARGET_LIST GoClone() {
            GO_TARGET_LIST clone_list = new GO_TARGET_LIST();
            foreach(GO_IP_PORT _ip_port in _ip_port_list)
            {
                clone_list.GoAdd(_ip_port.ip, _ip_port.port);
            }
            return clone_list;
        }

        /// <summary>
        /// 將IP組合Port匯成陣列
        /// </summary>
        /// <returns>IP:Port</returns>
        public string[] GoGetStringArray() {
            int _count = _ip_port_list.Count;

            string[] _s = new string[_count];
            for (int i = 0; i < _count; i++)
            {
                _s[i] = _ip_port_list[i].ip + ":" + _ip_port_list[i].port;
            }

            return _s;
        }



        /// <summary>
        /// 檢查IP&Port是不是表中獨有(不重複)的
        /// </summary>
        /// <param name="_item"></param>
        /// <returns>是獨有傳回true，否則false</returns>
        private bool GoIsUnique(GO_IP_PORT _item) {

            try
            {
                foreach (GO_IP_PORT item in _ip_port_list)
                {
                    if (item.ip == _item.ip && item.port == _item.port)
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }

}

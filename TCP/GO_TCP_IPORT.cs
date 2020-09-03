using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FakeBarcodePDA
{
    class GO_TCP_IPORT
    {
        public int go_port { get; set; }

        public IPAddress[] go_ip => Go_GetAddress();

        private List<string> list_ip = new List<string>();

        public GO_TCP_IPORT Go_AddIP(string ip) {
            list_ip.Add(ip);
            return this;
        }

        private IPAddress[] Go_GetAddress() {
            IPAddress[] _go_ip = new IPAddress[list_ip.Count];
            try
            { 
                for (int index = 0; index < list_ip.Count; index++) 
                {
                    _go_ip[index] = IPAddress.Parse(list_ip[index]);
                }
            }
            catch (Exception ex)
            {

            }
            return _go_ip;
        }
    }
}

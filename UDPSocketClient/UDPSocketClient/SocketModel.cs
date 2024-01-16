using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UDPSocketClient
{
    public class SockModel
    {
        const string req = "reqest";
        bool alive_color = false;
        IPEndPoint? fromEp = null;


        public string loop(UdpClient client)
        {
            byte[] data = Encoding.UTF8.GetBytes(req);
            client.Send(data, data.Length);

            byte[] recv = client.Receive(ref fromEp);
            string strRecv = BitConverter.ToString(recv);
            return strRecv;
        }
        public Color update_alive()
        {
            Color color = new Color();
            if (alive_color == false)
            {
                color = Color.Green;
                alive_color = true;
            }
            else
            {
                color = Color.Black;
                alive_color = false;
            }
            return color;

        }
        public string get_time()
        {
            DateTime now = DateTime.Now;
            string res = string.Format("[{0:yyyy/MM/dd HH:mm:ss.fff}]", now);
            return res;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace KeoBuaBao_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] ipaddr = Dns.GetHostAddresses("localhost");
            Socket newsock = new Socket(ipaddr[1].AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipep = new IPEndPoint(ipaddr[1], 9055);
            newsock.Bind(ipep);
            byte[] data = new byte[1024];
            EndPoint ep = ipep;
            Console.Write("Mo ket noi....");
            byte[] nhan = new byte[10];
            newsock.ReceiveFrom(nhan, ref ep);

                int result = Convert.ToInt32(Encoding.ASCII.GetString(nhan));
                byte[] nhan1 = new byte[20];
                string result1 = Encoding.ASCII.GetString(nhan1);
                Random re = new Random(DateTime.Now.Millisecond);
                int kq = re.Next(0, 3);
                if (kq == 0)
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Keo");
                    newsock.SendTo(gui, ep);
                }
                else if (kq == 1)
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Bua");
                    newsock.SendTo(gui, ep);
                }
                else
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Bao");
                    newsock.SendTo(gui, ep);
                }
                if ((kq == 0 && result == 0) || (kq == 1 && result == 1) || (kq == 2 && result == 2))
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Hoa");
                    newsock.SendTo(gui, ep);
                }
                else if ((kq == 0 && result == 1) || (kq == 1 && result == 2) || (kq == 2 && result == 0))
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Thang");
                    newsock.SendTo(gui, ep);
                }
                else
                {
                    byte[] gui = Encoding.ASCII.GetBytes("Thua");
                    newsock.SendTo(gui, ep);
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoUDP
{
    internal class Modtager
    {
        private int PORT;

        public Modtager(int port)
        {
            this.PORT = port;
        }
        public void Start()
        {
            using(UdpClient client = new UdpClient(PORT))
            {
                IPEndPoint AfsenderEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receive = client.Receive(ref AfsenderEP);

                Console.WriteLine("Modtager fra " + AfsenderEP.Address + " " + AfsenderEP.Port);
                string str = Encoding.ASCII.GetString(receive);
                Console.WriteLine("Modtaget \n" + str);

                //Ecko tilbage til afsender
                client.Send(receive, receive.Length, AfsenderEP);
            }
        }
    }
}

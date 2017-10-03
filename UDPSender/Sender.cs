using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPSender
{
   internal class Sender
    {
        private readonly int PORT;

        public Sender(int port)
        {
            PORT = port;
        }
        public void Start()
        {
            using (UdpClient client = new UdpClient())
            {
                IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
                string str = "Mathias";
                byte[] buffer = Encoding.ASCII.GetBytes(str);

                client.Send(buffer, buffer.Length, ModtagerEP);
            }

        }
    }
}

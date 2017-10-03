using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPSender
{
    class Program
    {
        private const int ModtagerPORT = 22334;
        static void Main(string[] args)
        {
            Sender m = new Sender(ModtagerPORT);
            m.Start();
            Console.ReadLine();


        }
    }
}

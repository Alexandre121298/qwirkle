using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace QwirkleLibrary
{
    class Client
    {
        public static void Connexion()
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpClient Client = new TcpClient();
            Client.Connect(ipAd, 8001);

            Stream stream = Client.GetStream();
        }
        public static void main()
        {
            try
            {

            }
            catch (Exception e)
            {

            }
        }
    }
}

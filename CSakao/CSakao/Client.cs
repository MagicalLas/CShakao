using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace CSakao
{
    class Client
    {
        TcpClient tcp;
        NetworkStream network;
        
        public Client()
        {
            tcp = new TcpClient("localhost",9090);
            network = tcp.GetStream();
        }
        public Client(int port)
        {
            tcp = new TcpClient("localhost", port);
            network = tcp.GetStream();
        }
        public Client(string host, int port)
        {
            tcp = new TcpClient(host, port);
            network = tcp.GetStream();
        }
        public void Send(string message) {
            byte[] ms = Encoding.Unicode.GetBytes(message);
            network.Write(Encoding.Unicode.GetBytes(message), 0, ms.Length);
            network.Flush();
        }
        public string Read() {

            byte[] ms = new byte[2048];
            int nbytes = network.Read(ms, 0, ms.Length);
            string output = Encoding.ASCII.GetString(ms, 0, nbytes);

            return output;
        }
        public void ShakeHand(string name) {
            Read();
            Read();
            Send(name);
        }
    }
}

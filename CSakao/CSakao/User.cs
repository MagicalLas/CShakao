using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSakao
{
    class User
    {
        Client client;
        string name;
        string id;
        MessageAnalyzer analyzer;
        User()
        {
            client = new Client(9090);
            name = "Null";
            id = name;
            client.ShakeHand(name);
        }
        User(string name)
        {
            client = new Client();
            this.name = name;
            client.ShakeHand(this.name);

        }
        public void SendMessage(string message)
        {
            if (analyzer.IsCommand(message))
            {
                analyzer.ExcuteCommand(message, client);
            }
            client.Send(message);
        }
        string ResiveMessage()
        {
            return client.Read();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSakao
{
    class MessageAnalyzer
    {
        public bool IsCommand(string message) {
            if (message[0] == '/') {
                return true;
            }
            return false;
        }
        public void ExcuteCommand(string command, Client client) {
            client.Send(command);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Abstraction
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Connect();
            Authenticate();
            SendMessage(message);
            Disconnect();
        }
        
        private void Connect()
        {
            Console.WriteLine("Connecting to mail server ...");
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticating user ...");
        }
        private void SendMessage(string message)
        {
            Console.WriteLine("Sending " + message);
            Console.WriteLine("Email sent Successfully!");
        }
        private void Disconnect()
        {
            Console.WriteLine("Disconnecting form mail server");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Abstraction
{
    public class BadEmailService
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to mail server ...");
        }
        public void Authenticate()
        {
            Console.WriteLine("Authenticating user ...");
        }
        public void SendEmail(string message)
        {
            Console.WriteLine("Sending " + message);
            Console.WriteLine("Email sent Successfully!");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnecting form mail server");
        }
    }
}

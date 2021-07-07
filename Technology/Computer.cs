using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Computer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string OS { get; set; }

        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}, the message was {message}");
        }
        public void CheckHealth()
        {
            Console.WriteLine("Device is super healthy");
        }

    }
}

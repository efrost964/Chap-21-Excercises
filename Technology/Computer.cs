using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Computer : AbstractEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string OS { get; set; }
        
        public Computer(string name, string brand, string os) : base()
        {
            Name = name;
            Brand = brand;
            OS = os;
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
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

        public string SendEmail(string recipient, string message)
        {
            string str = $"Email sent to {recipient}, the message was {message}";
            return str;
        }
        public string CheckHealth()
        {
            return "Device is super healthy";
        }

    }
}

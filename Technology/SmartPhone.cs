using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Laptop
    {
        public string Provider { get; set; }
        public SmartPhone(string name, string brand, string os, string provider) : base(name, brand, os)
        {
            Provider = provider;
        }

        public string MakeCall(int number)
        {
            return $"Calling {number}.... Ring... Ring...";
        }
    }
}

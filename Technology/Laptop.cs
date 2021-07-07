using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Laptop : Computer
    {
        public int BatteryLevel { get; set; }
        public Laptop(string name, string brand, string os) : base(name, brand, os)
        {
            BatteryLevel = 100;
        }
        public void CheckBatteryLevel()
        {
            BatteryLevel -= 5;
            Console.WriteLine(BatteryLevel);
        }
    }
}

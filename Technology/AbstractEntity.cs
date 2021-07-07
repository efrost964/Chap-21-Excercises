using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    abstract class AbstractEntity
    {
        public string IP { get; set; }
        public int number = 0;

        public AbstractEntity()
        {
            number++;
            IP = $"10.000.000.{number}";
            
        }
    }
}

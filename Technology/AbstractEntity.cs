using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technology;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public string IP { get; set; }
        //internal int number = 0;

        public AbstractEntity()
        {
            Program.number++;
            IP = $"10.000.000.{Program.number}";
            
        }
    }
}

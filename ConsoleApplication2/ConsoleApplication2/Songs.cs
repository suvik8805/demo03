using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Songs
    {
        public string Song { get; set; }
        public double Lenght { get; set; }

        public override string ToString()
        {
            return Song +", " + Lenght;
        }
    }
}
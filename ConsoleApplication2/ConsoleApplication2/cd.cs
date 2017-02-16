using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Songs { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("CD name:" +Name);
            Console.WriteLine("Songs:");
        }

    }


}

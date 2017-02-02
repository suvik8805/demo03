using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02_Pesukone
{
    class Pesukone
    {
        // properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Time { get; set; }
        public int Speed { get; set; }
        public string WashProgram { get; set; }

        //methods
        public void Wash()
        {
            Console.WriteLine("Washing is on.");
        
        }

        public void AddLaundry()
        {
            Console.WriteLine("Now you can put your laundry to the washing machine!");
        }

        public void PrintData()
        {
            Console.WriteLine("Choosed program:" + WashProgram);
            Console.WriteLine("Temperature is: " + Temperature);
            Console.WriteLine("Washing time is: " + Time + " min");
            Console.WriteLine("Sling speed is: " + Speed);
        
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_vehicle
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // methods
        public void PrintData()
        {
            Console.WriteLine("Vehicle properties are: ");
            Console.WriteLine("Vehicle's name is: " + Name);
            Console.WriteLine("Speed is: " + Speed);
            Console.WriteLine("Vehicle has " + Tyres + " tyres");

        }

        public string ToString(string Name, int Speed, int Tyres)
        {
            return Name + ", " +Speed ", " + Tyres;

        }
    }
}

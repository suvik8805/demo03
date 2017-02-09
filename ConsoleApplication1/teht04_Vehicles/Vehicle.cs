using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_Vehicles
{
    class Vehicle
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string name, string model, string year, string color)
        {
            Name = name;
            Model = model;
            ModelYear = year;
            Color = color;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Model: " + Model + ", Modelyear: " + ModelYear + ", Color: " + Color;
        }

    }
}

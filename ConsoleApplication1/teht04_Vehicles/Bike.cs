using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_Vehicles
{
    class Bike : Vehicle
    {

        public bool Wheels { get; set; }
        public string Gear { get; set; }



        public Bike() { }

        public Bike(string name, string model, string year, string color, bool wheels, string gear)
            :base (name, model, year, color)
            {
            Wheels= wheels;
            Gear = gear;
            }

         public override string ToString()
            {
            return base.ToString() + ", GearWheels: " + Wheels + ", Gear Name: " + Gear;
            }

}
}

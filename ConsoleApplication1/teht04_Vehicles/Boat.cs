using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_Vehicles
{
    class Boat: Vehicle
    {
        public int Seats { get; set; }
        public string Type { get; set; }


        public Boat() { }

        public Boat(string name, string model, string year, string color, int seats, string type )
            : base(name, model, year, color)
        {
            Seats = seats;
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + ", SeatCount: " + Seats + ", BoatType: " + Type;

        }

    }
}

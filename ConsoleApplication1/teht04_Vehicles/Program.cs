using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model="Street";
            bike.ModelYear = "2016";
            bike.Color = "Blue";
            bike.Wheels = false;
            Console.WriteLine(bike.ToString());

            Bike bike1 = new Bike();
            bike1.Name = "Tunturi";
            bike1.Model = "StreetPower";
            bike1.ModelYear = "2010";
            bike1.Color = "Black";
            bike1.Wheels = false;
            bike1.Gear = "Shimano";
            Console.WriteLine(bike1.ToString());

            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.ModelYear = "1990";
            boat.Color = "White";
            boat.Seats = 3;
            boat.Type = "Rowboat";
            Console.WriteLine(boat.ToString());

            Boat boat1 = new Boat();
            boat1.Name = "Yamaha";
            boat1.Model = "Model 1000";
            boat1.ModelYear = "2010";
            boat1.Color = "Yellow";
            boat1.Seats = 5;
            boat1.Type = "Motorboat";
            Console.WriteLine(boat1.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Car";
            vehicle.Speed = 90;
            vehicle.Tyres = 4;
            vehicle.PrintData();

            Vehicle vehicle2 = new Vehicle();
            vehicle2.Name = "Bike";
            vehicle2.Speed = 20;
            vehicle2.Tyres = 2;
            vehicle2.PrintData();

            Vehicle vehicle3 = new Vehicle();
            vehicle3.Name = "Tractor";
            vehicle3.Speed = 40;
            vehicle3.Tyres = 4;
            vehicle3.PrintData();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02_Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesu = new Pesukone();
            pesu.IsOn = true;
            pesu.Temperature = 40;
            pesu.Speed = 1000;
            pesu.WashProgram = "Kirjopesu";

            
            pesu.PrintData();
            pesu.AddLaundry();
            pesu.Wash();

        }
    }
}

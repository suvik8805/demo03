using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Artist = "Nightwish";
            cd.Name = "Endless Forms Most Beautiful";
            cd.Price = 13.99;
            cd.PrintData();


            List <Songs> biisit = new List <Songs>();
            biisit.Add(new Songs { Song = "Shudder Before the Beautiful", Lenght = 6.29 });
            biisit.Add(new Songs { Song = "Weak Fantasy", Lenght = 5.23 });
            biisit.Add(new Songs { Song = "Elan", Lenght = 4.45 });
            biisit.Add(new Songs { Song = "Yours Is an Empty Hope", Lenght = 5.34 });
            biisit.Add(new Songs { Song = "Our Decades in the Sun", Lenght = 6.37 });
            biisit.Add(new Songs { Song = "My Walden", Lenght = 4.38 });
            biisit.Add(new Songs { Song = "Endless Forms Most Beautiful", Lenght = 5.23 });
            biisit.Add(new Songs { Song = "Edema Ruh", Lenght = 5.15 });
            biisit.Add(new Songs { Song = "Alpenglow", Lenght = 4.45 });
            biisit.Add(new Songs { Song = "The Eyes of Sharbat Gula", Lenght = 6.03 });
            biisit.Add(new Songs { Song = "The Greatest Show on Earth", Lenght = 24.00 });

            foreach (Songs biisi in biisit)
            {
                Console.WriteLine(biisit.ToString());
            }
            
        }

    }
}

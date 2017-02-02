using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03_Televisio
{
    class Televisio
    {
        //properties
        public bool IsOn {get; set;}
        public int Channel { get; set; }
        public int Volume { get; set; }
        public string Show { get; set; }

        //methods
        public void PrintData()
        {

            Console.WriteLine();
            Console.WriteLine("Television is on");
            Console.WriteLine("Channel is: " + Channel);
            Console.WriteLine("Now you're watching is: " + Show);
            Console.WriteLine("Volume is: " + Volume);
        }

        public void AddVolume(int value)
        {
            Volume = Volume + value;
            Console.WriteLine("Volume is now: " + Volume);
        }

        public void SwitchChannel(int value)
        {
            Channel = value;
            if(Channel <= 2)
            {
                Console.WriteLine();
                Console.WriteLine("Choosed channel is: " + value);
                Console.WriteLine("Now you are watching news.");
            }
            if(Channel >2 && Channel <= 5)
            {
                Console.WriteLine();
                Console.WriteLine("Choosed channel is: " + value);
                Console.WriteLine("It's comedy time!");
            }
            if (Channel >5 && Channel <= 8 )
            {
                Console.WriteLine();
                Console.WriteLine("Choosed channel is: " + value);
                Console.WriteLine("Oh, They are showing an old movie here!");
            }
           if(Channel > 8)
            {
                Console.WriteLine();
                Console.WriteLine("Choosed channel is: " + value);
                Console.WriteLine("Come on! Everybody loves Reality TV!");
            }
        }

        
        

    }
}

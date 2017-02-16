using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Radio
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 9;
        private readonly int minFreq = 2000;
        private readonly int maxFreq = 26000;

        public bool RadioOn { get; set; }
        private int volume;
        public int Volume {

            get {

                return volume; 
            }

            set {
                if (minVolume <= volume && volume <= maxVolume)
                {
                    volume = 5;
                    Console.WriteLine("Volume is now: " + volume);

                }
                else
                    volume = 1;
                Console.WriteLine("Volume is too high. Volume is set to 1");
                    
                }

        }
        private int frequency;
        public int Frequency
        {

            get
            {

                return frequency;
            }

            set
            {
                if (minFreq <= frequency && volume <= maxFreq)
                {
                    frequency=10000;
                    Console.WriteLine("Radio frequency is now: " + frequency);

                }
                else
                    volume = 20000;
                Console.WriteLine("Frequency is not acceptable. Frequency is set to 20000");

            }

        }


        public Radio() { }



        public void PrintData()
        {
            Console.WriteLine("Radio is on: " + RadioOn);
            Console.WriteLine("Volume is: " + Volume);
            Console.WriteLine("Frequency is: " + Frequency);


        }
       }

}

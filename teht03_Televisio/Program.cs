using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03_Televisio
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio televisio = new Televisio();
            televisio.IsOn = true;
            televisio.Channel = 2;
            televisio.Show = "News";
            televisio.Volume = 15;
            televisio.PrintData();
            televisio.AddVolume(5);
            televisio.SwitchChannel(4);
        }
    }
}

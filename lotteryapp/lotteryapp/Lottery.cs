using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotteryapp
{
    class Lottery
    {
        public void Draw(){

            Random rand = new Random();
            int number = rand.Next(1, 39 + 1);
            List<int> list = new List<int>();
            list.Add(number);
            
        }
    }
}

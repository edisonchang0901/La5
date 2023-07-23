using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperAI : Player
    {
        public string Name => "SuperAI";

        public int Next(int low, int high)
        {
            return low;
        }
    }
}

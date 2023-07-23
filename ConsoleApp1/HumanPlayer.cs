using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HumanPlayer : Player
    {
        public string Name => "HumanPlayer";

        public int Next(int lowm, int high)
        {         
            return Int32.Parse(Console.ReadLine());            
        }
    }
}

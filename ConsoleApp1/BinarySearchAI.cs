using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinarySearchAI : Player
    {
        public string Name => "BinarySearchAI";

        public int Next(int lowm ,int high)
        {
           return (lowm + high) / 2;
        }
    }
}

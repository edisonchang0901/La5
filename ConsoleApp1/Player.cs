using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Player
    {
        public string Name { get; }
        public int Next(int lowm ,int high);
    }
}

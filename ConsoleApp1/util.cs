using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class util
    {
        /// <summary>
        /// 印猜數字問題
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        public static void PrintGuessingQuestion(int startRange, int endRange)
        {
            Console.WriteLine($"({startRange}, {endRange})?");
        }
    }
}

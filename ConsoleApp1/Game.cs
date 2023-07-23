using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public int secret_number { get; set; }
        public int high { get; set; } = 99;
        public int low { get; set; } = 0;
        public bool win_flag { get; set; }
        public Player player { get; set; }


        public Game(Player player)
        {
            Random random = new Random();
            secret_number = random.Next(100);
            this.player = player;
        }

        public void run() 
        {
            
            while (low != high)
            {
                int input = player.Next(low, high);
                // 排除超過範圍
                if (input < low || input > high)
                {
                    Console.WriteLine("Out of range. Try again?");
                    util.PrintGuessingQuestion(low, high);
                    continue;
                }

                // 命中範圍
                if (input == secret_number)
                {
                    win_flag = true;
                    Console.WriteLine("Bingo.");
                    return;
                }

                if (input < secret_number)
                {
                    low = input + 1;
                    util.PrintGuessingQuestion(low, high);
                    continue;
                }


                if (input > secret_number)
                {
                    high = input - 1;
                    util.PrintGuessingQuestion(low, high);
                    continue;
                }
            }
        }

        public bool hasWon() 
        {
            return win_flag;
        }

     
    }
}

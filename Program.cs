using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CTS
{
    class Program
    {
        [STAThread]
        static void Main(string[] args) 
        {
            Console.CursorVisible = false;
            Game game = new Game(50, 200);
            long last = 0;
            long milisecond = Stopwatch.Frequency / 1000;
            long start = Stopwatch.GetTimestamp() / milisecond;
            while (true)
            {
                long current = Stopwatch.GetTimestamp() / milisecond - start;

                if (last + 16 < current || current < last)
                {
                    if (game.Update(current))
                    {
                        break;
                    }
                    else
                    {
                        last = current;
                    }
                }

            }
        }
    }
}

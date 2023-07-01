using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            while (true)
            {
                Console.WriteLine("Start or Stop The StopWatch");
                var input = Console.ReadLine().ToLower();

                if (input == "start" && stopWatch._isStartOrStop == false)
                {
                    stopWatch.Start();
                    continue;
                }
                else if (input == "stop" && stopWatch._isStartOrStop == true)
                {
                    stopWatch.Stop();
                    Console.WriteLine(stopWatch.duration);
                    continue;
                }

                if (input == "start" && stopWatch._isStartOrStop == true)
                    Console.WriteLine("Please Do Not Start The Timer Twice");

                else if (input == "stop" && stopWatch._isStartOrStop == false)
                    Console.WriteLine("Please Do Not stop The Timer Twice");

                else
                    break;
            }
        }
    }
}

using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Stopwatcher time = new Stopwatcher();
         

        Console.WriteLine("Enter 'start' to begin the stopwatch, 'stop' to stop it, and 'exit' to quit the program.");
        while (true)
        {

            string command = string.Empty;
            command = Console.ReadLine().ToLower();

            if (command == "start")
            {
                if (time.clock.IsRunning)
                {
                    throw new InvalidOperationException("Stopwatch is already running.");

                }
                else
                {
                    time.Start();
                    Console.WriteLine("Stopwatch started.");
                }
            }
            else if (command == "stop")
            {
                if (time.clock.IsRunning)
                {
                    time.Stop();
                    
                    
                    Console.WriteLine($"Stopwatch stopped. Elapsed time: ");
                    Console.WriteLine("Elapsed time: ");
                    time.Display();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Stopwatch is not running.");
                }
            }
            else if (command == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please enter 'start', 'stop', or 'exit'.");
            }
        }
    }
}
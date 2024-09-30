
using System.Diagnostics;

namespace Projekt1;

static class Rainbow
{   
    static Stopwatch stopwatch = new Stopwatch();

    public static void Run()
    {   
        Random random = new Random();
        stopwatch.Restart();

        int count = 0;
        while (stopwatch.ElapsedMilliseconds < 1500)
        {
            Console.BackgroundColor = (ConsoleColor)random.Next(1, 15);
            Console.WriteLine("\n");
            Thread.Sleep(50);

            count++;
            if (count > 5)
            {
                count = 0;
                Task.Run(Console.Beep);
            }
        }

        // Reset console color after each rainbow
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
    }
} // Class Rainbow


using System.Diagnostics;

namespace Projekt1;

public class TheGenerator : TheGeneratorData
{
    private Random? random;
    private Stopwatch stopwatch;


    public TheGenerator()
    {   
        random = new Random();
        stopwatch = new Stopwatch();
    }

    public int GenerateRandomNumber(int from, int to)
    {
        return random.Next(from, to);
    }

    public void GenerateInsult(string userName)
    {   
        Console.WriteLine($"Here's yer daily insult {userName}");

        int i = random.Next(0, insults.Count); //takes a random string from the list of insults.
        string randomInsult = insults[i];
        Console.WriteLine(randomInsult);
    }

    public void GenerateMotivationalspeech(string userName)
    {
        Console.WriteLine($"Here's yer daily cheer-me-up {userName}");

        int i = random.Next(0, motivationalspeeches.Count);
        string randomMotivationalSpeech = motivationalspeeches[i];
        Console.WriteLine(randomMotivationalSpeech);
    }

    public void GenerateHamster()  // prints cool hamster
    {
        Console.WriteLine(" \n             .     .\r\n            (>\\---/<)\r\n            ,'     `.\r\n           /  q   p  \\\r\n          (  >(_Y_)<  )\r\n           >-' `-' `-<-.\r\n          /  _.== ,=.,- \\\r\n         /,    )`  '(    )\r\n        ; `._.'      `--<\r\n       :     \\        |  )\r\n       \\      )       ;_/  hjw\r\n        `._ _/_  ___.'-\\\\\\\r\n           `--\\\\\\");
    }

    public void GenerateRainbow()
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
}

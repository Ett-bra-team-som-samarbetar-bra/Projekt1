
using System;

namespace Projekt1;

class Program
{
    // Entry point va
    public static TheGenerator theGenerator = new();
    static void Main(string[] args)
    {
        Generator();
        FeelsMethod();
        Console.ReadKey();
    }

    public static void Generator()
    {
        int randomPick = TheGenerator.random.Next(0, 6);

        switch (randomPick)
        {
            case 0:
                TheGenerator.GenerateInsult();
                break;
            case 1:
                TheGenerator.GenerateMotivationalspeech();
                break;
            case 2:
                TheGenerator.Hamster();
                break;
            case 3:
                Rainbow.Run();
                break;
            case 4:
                SweetChildOfMine.Run();
                break;
            case 5:
                InteractiveMenu.Start();
                break;
            default:
                Console.WriteLine("That doenst exist... yet ;)");
                break;
        }
    }

    public static void FeelsMethod()
    {
        Console.WriteLine("On a scale from 1-10, how would you describe you feeling right now?");
        if (int.TryParse(Console.ReadLine(), out int feelNumber))
        {
            if (feelNumber < 5)
            {
                Console.WriteLine("Here, it sounds like you need a pick-me-up.");
                TheGenerator.GenerateMotivationalspeech();
            }
            else if (feelNumber == 10)
            {
                Rainbow.Run();
            }
            else if (feelNumber > 5)
            {
                Console.WriteLine("Oh really? We will see about that");
                TheGenerator.GenerateInsult();
            }
            else
            {
                Console.WriteLine("Perfectly lagom, as all things should be...");
            }
        }
        else
        {
            Console.WriteLine("Thats not an integer, is it?");
        }
    }

    //Add more methods

}

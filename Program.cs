
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
    }

    public static void Generator()
    {
        Random random = new Random();
        int randomPick = random.Next(0, 5);

        switch (randomPick)
        {
            case 0:
                InsultGenerator();
                break;
            case 1:
                GenerateMotivationalSpeech();
                break;
            case 2:
                Console.WriteLine("Random Love Poem: ");
                break;
            case 3:
                TheGenerator.Hamster();
                break;
            case 4:
                Rainbow.Run();
                break;
        }
    }

    public static void GenerateMotivationalSpeech()
    {
        theGenerator.GenerateMotivationalspeech();
    }

    public static void InsultGenerator()
    {
        theGenerator.GenerateInsult();
    }

    public static void FeelsMethod()
    {

        Console.WriteLine("On a scale from 1-10, how would you describe you feeling right now?");
        if (int.TryParse(Console.ReadLine(), out int feelNumber))
        {

            if (feelNumber < 5)
            {
                Console.WriteLine("Here, it sounds like you need a pick-me-up.");
                GenerateMotivationalSpeech();
            }
            else if (feelNumber > 5)
            {
                Console.WriteLine("Oh really? We will see about that");
                InsultGenerator();
            }
            else if (feelNumber == 10)
            {
                Rainbow.Run();
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
        Console.ReadKey();
    }

    //Add more methods

}

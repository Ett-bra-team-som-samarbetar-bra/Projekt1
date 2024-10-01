
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projekt1;

class Program
{
    public static string userName = "";
    static void Main(string[] args)
    {
        GetUserName();
        WizardCheck();
        Generator(); // Starting the program by randomly selecting an event.
        FeelsMethod();
        Console.ReadKey();
    }


    public static void GetUserName()
    {
        Console.WriteLine("What's your name?");
        userName = Console.ReadLine();
    }

    public static void Generator()
    {
        int randomPick = TheGenerator.random.Next(0, 8); // picking a random number from 0-8 to place in the switch statement

        switch (randomPick)
        {
            case 0:
                Console.WriteLine($"Here's yer daily insult {userName}");
                TheGenerator.GenerateInsult();
                break;
            case 1:
                Console.WriteLine($"Here's yer daily cheer-me-up {userName}");
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
            case 6:
                MusicBox.Blues();
                break;
            case 7:
                MusicBox.Pirates();
                break;
            default:
                break;
        }
    }

    public static void WizardCheck()
    {
        if (userName.Equals("Harry"))
        {
            Console.WriteLine($"You're a wizard, {userName}");
        }
        else {
            Console.WriteLine($"Sadly, you're not a wizard {userName}");
        }

        Console.WriteLine("Good morning " + userName + "!");
    }

    public static void FeelsMethod()
    {
         //Making sure the user is satisfied with the randomly generated event.
        Console.WriteLine($"On a scale from 1-10, how would you describe you feeling right now {userName}?");
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

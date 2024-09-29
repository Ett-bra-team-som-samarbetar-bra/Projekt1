
using System;

namespace Projekt1;

class Program
{
    // Entry point va
    public static TheGenerator theGenerator = new();
    static void Main(string[] args)
    {
        Generator();
    }

    public static void Generator()
    {
        Random random = new Random();
        int randomPick = random.Next(0, 3); 

        switch (randomPick)
        {
            case 0:
                InsultGenerator();
                break;
            case 1:
                Console.WriteLine("Random Motivation: ");
                break;
            case 2:
                Console.WriteLine("Random Love Poem: ");
                break;
        }
    }

    public static void InsultGenerator()
    {
        theGenerator.GenerateInsult();
    }
    //Add more methods

}

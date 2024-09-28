
using System;

namespace Projekt1;

class Program
{
    // Entry point va
    public static DiceGame diceGame = new DiceGame();
    static void Main(string[] args)
    {

        Console.WriteLine("Jesper take over VA");
        int x = 10;
        Console.WriteLine(x);
        Console.WriteLine("VAR ÄR KOMMENTARERNA?!?!?!!?!!?");
        x = 10;
        Console.WriteLine("Något annat än gorgonzola");

        Console.WriteLine("Gorgonzola");
        PlayGame();
        
    }

    public static void PlayGame()
    {
        diceGame.InitializePlayers();

    }




}

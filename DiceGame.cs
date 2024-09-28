using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class DiceGame
    {
        private string? playerOne;
        private string? playerTwo;
        private int playerOnePoints = 0;
        private int playerTwoPoints = 0;

        public void InitializePlayers()
        {
            Console.Clear();
            System.Console.WriteLine("Enter name of player one: ");
            playerOne = Console.ReadLine()!;
            System.Console.WriteLine("Enter name of player two: ");
            playerTwo = Console.ReadLine()!;

        }

    }


}

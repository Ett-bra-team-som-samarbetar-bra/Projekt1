using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    internal class InteractiveMenu
    {

        public static void Start()
        {
            RunMainMenu();
        }

        private static void RunMainMenu()
        {
            string prompt = "How lucky! You got to choose your own number! What would you like to see?\nUse the arrow keys to cycle through the options and press enter to select an option";
            string[] options = { "Insult", "Motivational Quote", "Hamster", "Rainbow", "Sweet Child o' Mine" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.RunMenu();
            

            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("That was not a hamster. Here, take a hamster instead!");
                    TheGenerator.Hamster();
                    break;
                case 1:
                    Console.WriteLine("That was not a hamster. Here, take a hamster instead!");
                    TheGenerator.Hamster();
                    break;
                case 2:
                    Console.WriteLine("Hamster!");
                    TheGenerator.Hamster();
                    break;
                case 3:
                    Console.WriteLine("That was not a hamster. Here, take a hamster instead!");
                    TheGenerator.Hamster();
                    break;
                case 4:
                    Console.WriteLine("That was not a hamster. Here, take a hamster instead!");
                    TheGenerator.Hamster();
                    break;
                default:
                    Console.WriteLine("That was not a hamster. Here, take a hamster instead!");
                    TheGenerator.Hamster();
                    break;
            }
        }

        

    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options) 
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = ">";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix} {currentOption}");
            }
            Console.ResetColor();

        }

        public int RunMenu()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex --;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length-1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex ++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while(keyPressed != ConsoleKey.Enter);
            
            return SelectedIndex;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Terminal_Battle
{
    class Menu
    {
        private int selectedIndex;
        private string[] options;
        private string prompt;

        public Menu(string _prompt, string[] _options)
        {
            prompt = _prompt;
            options = _options;
            selectedIndex = 0;
        }

        private void DisplyOptions()
        {
            WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                string prefix;

                if (i == selectedIndex)
                {
                    prefix = ">>";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{prefix} <{currentOption}>");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplyOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update selectedIndex
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = options.Length -1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                }

            }while (keyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}
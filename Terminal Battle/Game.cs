using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Terminal_Battle
{
    class Game
    {
        static void Main(string[] args)
        {
            //Set up name
            Console.Title = "Terminal Battle";
            Console.WindowWidth = 168;
            
            RunMainMenu();

            void StartGame()
            {
                //Pick a random enemy
                string[] enemyNames = { "Fiesty Dawg", "ur mom", "Pudge-a-wudge" };
                Random ranEnemy = new Random();
                int enemy = ranEnemy.Next(enemyNames.Length);

                //ask player for their name and use it as the player's name
                Console.WriteLine("Name Your Player: ");
                string insertedName = Console.ReadLine();

                //create an instance of a new plater
                Player player = new Player(insertedName);

                //create an instance of Fiesty Dawg
                Fiesty_Dawg enemy1 = new Fiesty_Dawg();

                enemy1.fiestyDawgBattle();
            }

            void RunMainMenu()
            {
                Console.ForegroundColor = ConsoleColor.Green;

                //Create starting menu
                string _prompt = @"
 _________  _______   ________  _____ ______   ___  ________   ________  ___               ________  ________  _________  _________  ___       _______      
|\___   ___\\  ___ \ |\   __  \|\   _ \  _   \|\  \|\   ___  \|\   __  \|\  \             |\   __  \|\   __  \|\___   ___\\___   ___\\  \     |\  ___ \     
\|___ \  \_\ \   __/|\ \  \|\  \ \  \\\__\ \  \ \  \ \  \\ \  \ \  \|\  \ \  \            \ \  \|\ /\ \  \|\  \|___ \  \_\|___ \  \_\ \  \    \ \   __/|    
     \ \  \ \ \  \_|/_\ \   _  _\ \  \\|__| \  \ \  \ \  \\ \  \ \   __  \ \  \            \ \   __  \ \   __  \   \ \  \     \ \  \ \ \  \    \ \  \_|/__  
      \ \  \ \ \  \_|\ \ \  \\  \\ \  \    \ \  \ \  \ \  \\ \  \ \  \ \  \ \  \____        \ \  \|\  \ \  \ \  \   \ \  \     \ \  \ \ \  \____\ \  \_|\ \ 
       \ \__\ \ \_______\ \__\\ _\\ \__\    \ \__\ \__\ \__\\ \__\ \__\ \__\ \_______\       \ \_______\ \__\ \__\   \ \__\     \ \__\ \ \_______\ \_______\
        \ |__|  \|_______|\|__|\|__|\|__|     \|__|\|__|\|__| \|__|\|__|\|__|\|_______|        \|_______|\|__|\|__|    \|__|      \|__|  \|_______|\|_______|";
                string[] _options = {"Play", "Options", "How To Play", "Exit", "Credits"};
                Menu mainMenu = new Menu(_prompt, _options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                    PlayGame();
                        break;
                    case 1:
                    Options();
                        break;
                    case 2:
                    HowTo();
                        break;
                    case 3:
                    ExitGame();
                        break;
                    case 4:
                    GameCredits();
                        break;
                }
            }

            void PlayGame()
            {
                Console.Clear();
                StartGame();
            }
            void Options()
            {
                Console.Clear();
                Console.WriteLine("Nothing here yet...\nPress Esc to Exit.");
                ConsoleKeyInfo pressedKey = ReadKey();
                if(pressedKey.Key == ConsoleKey.Escape)
                {
                    RunMainMenu();
                }
            }
            void HowTo()
            {
                Console.Clear();
                Console.WriteLine(@"
 HOW TO PLAY TERMINAL BATTLE
=============================
    Terminal Battle is what it's name says it is! It is a battle game inside a terminal enviorment!
    (If the big text looks weird, enter full-screen.)
    
    
 CONTROLLS
===========
    Change Selection: Up/Down Arrows
    Select Button: Enter
    Exit Back To Main Menu: Esc

    
 VERSION
=========
    Alpha 0.1.0");
                ConsoleKeyInfo pressedKey = ReadKey();
                if(pressedKey.Key == ConsoleKey.Escape)
                {
                    RunMainMenu();
                }
            }
            void ExitGame()
            {
                Console.Clear();
                Console.WriteLine(@"ARE YOU SURE YOU WANT TO EXIT TERMINAL BATTLE?

                YES: ENTER   NO: ESC");
                ConsoleKeyInfo pressedKey = ReadKey();
                if(pressedKey.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }
                else if(pressedKey.Key == ConsoleKey.Escape)
                {
                    RunMainMenu();
                }
            }
            void GameCredits()
            {
                Console.Clear();
                Console.WriteLine(@"
 _________  _______   ________  _____ ______   ___  ________   ________  ___               ________  ________  _________  _________  ___       _______      
|\___   ___\\  ___ \ |\   __  \|\   _ \  _   \|\  \|\   ___  \|\   __  \|\  \             |\   __  \|\   __  \|\___   ___\\___   ___\\  \     |\  ___ \     
\|___ \  \_\ \   __/|\ \  \|\  \ \  \\\__\ \  \ \  \ \  \\ \  \ \  \|\  \ \  \            \ \  \|\ /\ \  \|\  \|___ \  \_\|___ \  \_\ \  \    \ \   __/|    
     \ \  \ \ \  \_|/_\ \   _  _\ \  \\|__| \  \ \  \ \  \\ \  \ \   __  \ \  \            \ \   __  \ \   __  \   \ \  \     \ \  \ \ \  \    \ \  \_|/__  
      \ \  \ \ \  \_|\ \ \  \\  \\ \  \    \ \  \ \  \ \  \\ \  \ \  \ \  \ \  \____        \ \  \|\  \ \  \ \  \   \ \  \     \ \  \ \ \  \____\ \  \_|\ \ 
       \ \__\ \ \_______\ \__\\ _\\ \__\    \ \__\ \__\ \__\\ \__\ \__\ \__\ \_______\       \ \_______\ \__\ \__\   \ \__\     \ \__\ \ \_______\ \_______\
        \ |__|  \|_______|\|__|\|__|\|__|     \|__|\|__|\|__| \|__|\|__|\|__|\|_______|        \|_______|\|__|\|__|    \|__|      \|__|  \|_______|\|_______|           
                                    
     LEAD DEVELOPER
    ================
        RandomNPC
                                    
     HELPFUL YOUTUBE CHANNELS
    ==========================
        BRACKEYS
        MICHAEL HADLEY
                
                
                
                
                
                
                
                
                
Press Esc to return to the main menu.");
                ConsoleKeyInfo pressedKey = ReadKey();
                if(pressedKey.Key == ConsoleKey.Escape)
                {
                    RunMainMenu();
                }
            }
        }
    }
}

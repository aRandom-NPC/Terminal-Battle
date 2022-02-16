using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Terminal_Battle
{
    class Fiesty_Dawg
    {
        public float enemyAttk;
        public int enemyDef;
        public float enemyHp;

        public void fiestyDawgBattle()
                {
                    //Create an instence of Fiesty Dawg
                    Fiesty_Dawg enemy1 = new Fiesty_Dawg();

                    string _prompt = @"
        ,--._______,-. 
       ,','  ,    .  ,_`-. 
      / /  ,' , _` ``. |  )       `-.. 
     (,';'""`/ ''`-._ ` \/ ______    \\ 
       : ,o.-`- ,o.  )\` -'      `---.)) 
       : , d8b ^-.   '|   `.      `    `. 
       |/ __:_     `. |  ,  `       `    \ 
       | ( ,-.`-.    ;'  ;   `       :    ; 
       | |  ,   `.      /     ;      :    \ 
       ;-'`:::._,`.__),'             :     ; 
      / ,  `-   `--                  ;     | 
     /  \                   `       ,      | 
    (    `     :              :    ,\      | 
     \   `.    :     :        :  ,'  \    : 
      \    `|-- `     \ ,'    ,-'     :-.-'; 
      :     |`--.______;     |        :    : 
       :    /           |    |         |   \ 
       |    ;           ;    ;        /     ; 
     _/--' |           :`-- /         \_:_:_| 
   ,',','  |           |___ \ 
   `^._,--'           / , , .) 
                      `-._,-'
Fiesty Dawg Approaches!";
                    string[] _options = {"Fight", "Item", "Flee"};
                    Menu FeistyDawgMenu = new Menu(_prompt, _options);
                    int selectedIndexFD = FeistyDawgMenu.Run();

                    switch (selectedIndexFD)
                    {
                        case 0:
                    
                            break;
                        case 1:
                    
                            break;
                        case 2:
                        Console.Clear();
                        Console.WriteLine("Are You Sure?\nPress Enter to return to the main menu, or press Esc to go back.");
                        ConsoleKeyInfo pressedKey = ReadKey();
                        if(pressedKey.Key == ConsoleKey.Enter)
                        {
                            
                        }
                        else if(pressedKey.Key == ConsoleKey.Escape)
                        {
                            fiestyDawgBattle();
                        }
                            break;
                    }
                }
        
        
            

        public Fiesty_Dawg()
        {
            enemyHp = 25f;
            enemyAttk = 5f;
            enemyDef = 3;
        }
    }
}
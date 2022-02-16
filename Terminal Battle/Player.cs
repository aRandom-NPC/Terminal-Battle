using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Terminal_Battle
{

    class Player
    {
        public float playerHp;
        public float playerAttk;
        public string name;
        public int playerDef;

        public Player(string _playerName)
        {
            playerHp = 35f;
            playerAttk = 5f;
            name = _playerName;
        }
    }
}
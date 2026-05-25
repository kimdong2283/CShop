using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Player:Character
    {
        private int _level;
        public int Level
        {
            get { return _level; }
            set
            {           
                if(value > 0)
                {
                    value = 1;
                }
                else
                {
                    _level = value;
                }
            }
        }
        public Player(string name, int hp, int attack) : base(name, hp, attack)
        {

        }
    }
}

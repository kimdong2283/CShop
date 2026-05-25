using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Character
    {
        private string _name;
        private int _hp;
        private int _attack;
        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                if(int.TryParse(value, out _))
                {
                    return;
                }
                _name = value;
            }
        }

        public int Hp
        {
            get { return _hp; }

            set
            { 
                if(value >0)
                {
                    _hp = value;
                }
            }
        }
        public int Attack
        {
            get { return _attack; }
            set
            {
                if(value > 0)
                {
                    _attack = value;
                }
            }

        }

        public Character() { }
        public Character(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void TakeDamage(int damage) 
        {
            Hp -= damage;
            if(Hp<0) Hp = 0;
        }

        public bool IsDead()
        {
            return Hp < 0;
        }

    }
}

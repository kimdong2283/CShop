using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Monster:Character
    {
        public Monster(string name, int hp , int attack):base(name, hp, attack)
        {
    
        }
        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp < 0) Hp = 0;
        }
    }
}

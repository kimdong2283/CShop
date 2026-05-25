using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Active
    {

        public void LevelUp(Player player)
        {
            player.Level++;
            Console.WriteLine($"{player.Name} leveled up to level {player.Level}!");
        }
    }
}

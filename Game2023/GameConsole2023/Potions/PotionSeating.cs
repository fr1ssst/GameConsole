using GameConsole2023.Creaturs;
using GameConsole2023.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Potions
{
    abstract class PlayerPotion : NameTrait
    {
        protected int value = 0;
        public PlayerPotion(int value)
        {
            this.value = value;
        }

    }
}

using GameConsole2023.Creaturs;
using GameConsole2023.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Potions
{
    internal class PotionSeating
    {
        abstract class PlayerPotion : NameTrait
        {
            protected int size = 0;

            private string generatePotionName()
            {
                if (size == 1)
                {
                    return "Little";
                }
                else if (size == 2)
                {
                    return "Regular";
                }
                else
                {
                    return "Legendary";
                }
            }


            public PlayerPotion(int size)
            {
                this.size = size;
                this.name = generatePotionName() + this.GetType().Name;
            }
        }
    }
}

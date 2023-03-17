using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameConsole2023.Potions.PlayerPotion;
using GameConsole2023.Creaturs;
using GameConsole2023.GameInterface;

namespace GameConsole2023.Potions
{

    class HealthPotion : PlayerPotion, IUsePotion
    {       
        int m_value;
        public HealthPotion(int value) : base(value)
        {
            m_value = value;
        }

        public void UsePotion(BasePersone persone)
        {
            persone.heal(m_value);
        }
        public string getNamePotion() 
        {
            return "HealthPotion";
        }
    }
}

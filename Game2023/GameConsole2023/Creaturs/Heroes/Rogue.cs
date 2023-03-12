using GameConsole2023.Creaturs;
using System;

namespace GameConsole2023.Creaturs.Heroes
{
    internal class Rogue : BasePersone
    {
        Random random = null;
        public Rogue(string name) : base(name)
        {
            random = new Random();

            this.classPlayer = "Розбійник";
            this.health = 600;
            this.energy = 95;
            this.power = random.Next(54, 62);
            this.agility = 325;
            this.endurance = 30;
            this.armor = 3;
            this.level = 1;
            this.numberOFEP = 339;
        }
    }
}

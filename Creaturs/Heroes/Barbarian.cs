using GameConsole2023.Creaturs;
using System;


namespace GameConsole2023.Creaturs.Heroes
{
    internal class Barbarian : BasePersone
    {
        Random random = null;
        public Barbarian(string name) : base(name)
        {
            random = new Random();

            this.classPlayer = "Нападник";
            this.health = 620;
            this.energy = 90;
            this.power = random.Next(41, 51);
            this.agility = 325;
            this.endurance = 45;
            this.armor = 2;
            this.level = 1;
            this.numberOFEP = 243;
        }
    }
}

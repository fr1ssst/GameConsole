using GameConsole2023.Creaturs;
using System;


namespace GameConsole2023.Creaturs.Heroes
{
    internal class Tank : BasePersone
    {
        Random random = null;
        public Tank(string name) : base(name)
        {
            random = new Random();

            this.classPlayer = "Танк";
            this.health = 760;
            this.energy = 110;
            this.power = random.Next(55, 59);
            this.agility = 310;
            this.endurance = 50;
            this.armor = 3.2;
            this.level = 1;
            this.numberOFEP = 291;
        }
    }
}

using GameConsole2023.Creaturs;
using System;

namespace GameConsole2023.Creaturs.NPC
{
    internal class Enemy : BasePersone
    {
        Random random = null;
        public Enemy(string name, int level) : base(name, new Random())
        {
            random = new Random();
            this.health = random.Next(700, 900);
            this.maxHp = health;
            this.energy = random.Next(90, 110);
            this.power = random.Next(55, 62) * 2;
            this.agility = 315;
            this.endurance = random.Next(30, 50);
            this.level = 1;
            this.numberOFEP = random.Next(50, 300);
        }
    }
}

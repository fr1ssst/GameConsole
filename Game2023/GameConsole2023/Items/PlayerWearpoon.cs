using GameConsole2023.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Items
{
    class Weapon : Item
    {

        public Weapon(string name, int damage) : base(name, damage)
        {

        }
        public double getDamage() => this.value;
    }
}

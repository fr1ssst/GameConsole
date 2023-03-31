using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole2023.Items;
using static System.Net.Mime.MediaTypeNames;

namespace GameConsole2023.Items
{
    class Armor : Item
    {
        public Armor(string name, int protect) : base(name, protect)
        {
        }

        public int getProtect() => this.value;
    }
}

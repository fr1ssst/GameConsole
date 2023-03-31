using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Items
{
    abstract class Item
    {
        protected string name;
        protected int value;

        public Item(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public string getName() => this.name;
    }
}

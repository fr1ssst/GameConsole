using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Ratyshnui.Items
{
    public class Armor
    {
        private string nameArmor;
        private double protectionArmor;
        public Armor(string nameArmor, double protection)
        {
            this.nameArmor = nameArmor;
            this.protectionArmor = protection;
        }
        public void setNameArmor(string name) => this.nameArmor = nameArmor;
        public string getNameArmor() => this.nameArmor;
        public void setProtection() => this.protectionArmor = protectionArmor;
        public double getProtection() => this.protectionArmor;
    }
}

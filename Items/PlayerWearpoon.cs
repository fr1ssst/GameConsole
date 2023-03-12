using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Ratyshnui.Items
{
    public class Weapon
    {
        private string nameWeapon;
        private double protectionWeapon;
        public Weapon(string nameWeapon, double protectionWeapon)
        {
            this.nameWeapon = nameWeapon;
            this.protectionWeapon = protectionWeapon;
        }
        public void setNameWeapon(string name) => this.nameWeapon = nameWeapon;
        public string getNameWeapon() => this.nameWeapon;
        public void setProtectionWeapon() => this.protectionWeapon = protectionWeapon;
        public double getProtectionWeapon() => this.protectionWeapon;
    }
}

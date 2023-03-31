using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Different;
using GameConsole2023.GameEngine;
using GameConsole2023.GameInterface;
using GameConsole2023.Items;
using System;
using System.Collections.Generic;
using static GameConsole2023.GameInterface.ISkill.SkillInterface;

namespace GameConsole2023.Creaturs
{

    abstract class BasePersone
    {
        Random random = null;

        protected Weapon weapon = new Weapon("", 0);
        protected Armor armor = new Armor("", 0);

        protected List<IUseCombatSkill> skills = new List<IUseCombatSkill>();
        protected List<IUsePotion> potions = new List<IUsePotion>();

        protected double health = 0; //здоров'я
        protected double maxHp = 0; //максимальне здоров'я
        protected double energy = 0; //енергія
        protected int power = 0; //сила
        protected double agility = 0; //спритність
        protected double endurance = 0; //витривалість
        protected int level = 0; //рівень
        protected double numberOFEP = 0; //очки досвіду
        protected string classPlayer = ""; //клас гравця 
        protected string name = ""; //ім'я 
        protected int coin = 0;

        public BasePersone(string name, Random random)
        {
            this.name = name;
            this.random = random;
        }
        public void showInfoBlockText(string text1, string text2, ConsoleColor color1 = ConsoleColor.White, ConsoleColor color2 = ConsoleColor.Red)
        {
            Console.ForegroundColor = color1;
            Console.Write(text1);

            Console.ForegroundColor = color2;
            Console.Write(text2);

            Console.WriteLine();
        }
        public void showInfoBlockVaule(string text, double valueP, ConsoleColor color1 = ConsoleColor.White, ConsoleColor color2 = ConsoleColor.Red)
        {
            Console.ForegroundColor = color1;
            Console.Write(text);

            Console.ForegroundColor = color2;
            Console.Write(valueP);

            Console.WriteLine();
        }
        public void setCoin(int coin) => this.coin = coin;
        public int getCoin() => this.coin;
        public void setClassPlayer(string classPlayer) => this.classPlayer = classPlayer;
        public string getClassPlayer() => this.classPlayer;
        public void setHealth(double health) 
        {
            if (health < 0)
            {
                this.health = 0;
            }
            else
            {
                this.health = health;
            }
        }
        public double getHealth() => this.health;
        public void setMaxHp() => this.maxHp = health;
        public double getMaxHp() => this.maxHp;
        public void setEnergy(double energy)
        {
            if (energy < 0)
            {
                this.energy = 0;
            }
            else
            {
                this.energy = energy;
            }
        }
        public double getEnergy() => this.energy;
        public void setPower(int power)
        {
            if (power < 0)
            {
                this.power = 0;
            }
            else
            {
                this.power = power;
            }
        }
        public int getPower() => this.power;
        public void setAgility(double agility)
        {
            if (agility < 0)
            {
                this.agility = 0;
            }
            else
            {
                this.agility = agility;
            }
        }
        public double getAgility() => this.agility;
        public void setEndurance(double endurance)
        {
            if (endurance < 0)
            {
                this.endurance = 0;
            }
            else
            {
                this.endurance = endurance;
            }
        }
        public double getEndurance() => this.endurance;
        public void setLevel(int level) => this.level = level;
        public int getLevel() => this.level;
        public void setNumberOFEP(double numberOFEP)
        {
            if (numberOFEP < 0)
            {
                this.numberOFEP = 0;
            }
            else
            {
                this.numberOFEP = numberOFEP;
            }
        }
        public double getNumberOFEP() => this.numberOFEP;
        public void setName(string name) => this.name = name;
        public string getName() => this.name;
        //Skill
        public void addSkill(IUseCombatSkill skill)
        {
            this.skills.Add(skill);
        }
        public void showSkillList()
        {
            int index = 0;

            Console.WriteLine("Вибрати скіл: ");
            foreach (var item in this.skills)
            {
                Console.WriteLine($"{index} - {item.getName()}");
                index++;
            }
        }
        public void useSkill(int index, Enemy mob)
        {
            this.skills[index].useSkill(mob);
        }
        //Potion
        public void addPoition(IUsePotion poition)
        {
            this.potions.Add(poition);
        }
        public void usePoition(int index, BasePersone persone)
        {
            this.potions[index].UsePotion(this);
            this.potions.Remove(this.potions[index]);
        }
        public void showPotionsList() 
        { 
            int index = 0;

            Console.WriteLine("Вибрати зіля");
            foreach (var item in this.potions)
            {
                Console.WriteLine($"{index} - {item.getNamePotion()}");
                index++;
            }
        }
        public void heal(int value)
        {
            if (this.health + value > this.maxHp)
            {
                this.health = this.maxHp;
            }
            else
            {
                this.health += value;
            }
        }
        //Damage for Enemy
        public void damaged(int value) 
        {
            this.health -= value;
        }
        public void causingDamage(int power) 
        {
            if(power - this.armor.getProtect() > 0) 
            {
                this.damaged(power - this.armor.getProtect());
            }
        }
        public void setWeapon(Weapon weapon) => this.weapon = weapon;
        public void setArmor(Armor armor) => this.armor = armor;
        //Info
        public void showInfoPlayer()
        {
            showInfoBlockText("•Клас гравця: ", this.classPlayer, color2: ConsoleColor.Blue);
            showInfoBlockVaule($"•Здоров'я гравця: {this.health} / ", this.maxHp, color2: ConsoleColor.Red);
            showInfoBlockVaule("•Енергія гравця: ", this.energy, color2: ConsoleColor.Cyan);
            showInfoBlockVaule("•Сила гравця: ", this.power, color2: ConsoleColor.Green);
            showInfoBlockVaule("•Спритність гравця: ", this.agility, color2: ConsoleColor.DarkCyan);
            showInfoBlockVaule("•Витривалість гравця: ", this.endurance, color2: ConsoleColor.Green);
            Console.WriteLine($"Armor: {this.armor.getName()} - {this.armor.getProtect()}");
            Console.WriteLine($"Weapon: {this.weapon.getName()} - {this.weapon.getDamage()}");
            showInfoBlockVaule("•Золото гравця: ", this.coin, color2: ConsoleColor.Yellow);
            showInfoBlockVaule("•Рівень гравця: ", this.level, color2: ConsoleColor.DarkYellow);
            showInfoBlockVaule("•Кількість очків досвіду гравця: ", this.numberOFEP, color2: ConsoleColor.DarkBlue);
            showInfoBlockText("•Ім’я гравця: ", this.name, color2: ConsoleColor.Blue);
        }
        public void showInfoEnemy()
        {
            showInfoBlockVaule($"•Здоров'я ворога: {this.health} / ", this.maxHp, color2: ConsoleColor.Red);
            showInfoBlockVaule("•Енергія ворога: ", this.energy, color2: ConsoleColor.Cyan);
            showInfoBlockVaule("•Сила ворога: ", this.power, color2: ConsoleColor.Green);
            showInfoBlockVaule("•Спритність ворога: ", this.agility, color2: ConsoleColor.DarkCyan);
            showInfoBlockVaule("•Витривалість ворога: ", this.endurance, color2: ConsoleColor.Green);   
            showInfoBlockVaule("•Рівень ворога: ", this.level, color2: ConsoleColor.DarkYellow);
            showInfoBlockVaule("•Кількість очків досвіду ворога: ", this.numberOFEP, color2: ConsoleColor.DarkBlue);
            showInfoBlockText("•Ім’я ворога: ", this.name, color2: ConsoleColor.Blue);
        }
        public Weapon CreateWeapon()
        {
            string[] namesColdWeapon = {"Кинжал", "Спис", "Сковорідка",
                "Булава", "Топор", "Катана" };
            return new Weapon(namesColdWeapon[this.random.Next(0, namesColdWeapon.Length)], random.Next(5, 20));
        }
        public Armor CreateArmor()
        {
            string[] namesArmor = { "Металева броня", "Кольчужна броня", "Титанова броня", "", "", "" };
            return new Armor(namesArmor[this.random.Next(0, namesArmor.Length)], this.random.Next(3, 21));
        }
    }
}

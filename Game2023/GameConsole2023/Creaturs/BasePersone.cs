using GameConsole2023.Creaturs.NPC;
using GameConsole2023.GameInterface;
using System;
using System.Collections.Generic;
using static GameConsole2023.GameInterface.ISkill.SkillInterface;

namespace GameConsole2023.Creaturs
{
    abstract class BasePersone
    {

        Random random = null;
        protected List<IUseCombatSkill> skills = new List<IUseCombatSkill>();
        protected List<IUsePotion> potions = new List<IUsePotion>();
       
        protected double health = 0; //здоров'я
        protected double maxHp = 0;
        protected double energy = 0; //енергія
        protected double power = 0; //сила
        protected double agility = 0; //спритність
        protected double endurance = 0; //витривалість
        protected double armor = 0; //броня
        protected int level = 0; //рівень
        protected double numberOFEP = 0; //очки досвіду
        protected string classPlayer = ""; //клас гравця 
        protected string name = ""; //ім'я 

        public BasePersone(string name)
        {
            this.name = name;
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

        public void setClassPlayer(string classPlayer) => this.classPlayer = classPlayer;
        public string getClassPlayer() => this.classPlayer;
        public void setHealth(double health) => this.health = health;
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
        public void setPower(double power)
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
        public double getPower() => this.power;
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
        public void setArmor(double armor) => this.armor = armor;
        public double getArmor() => this.armor;
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
            this.potions[index].UsePotion(persone);
            //this.potions[index].UsePotion(this);
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
        //Info
        public void showInfoPlayer()
        {
            showInfoBlockText("•Клас гравця: ", this.classPlayer, color2: ConsoleColor.Blue);
            showInfoBlockVaule("•Здоров'я гравця: ", this.health, color2: ConsoleColor.Red);
            showInfoBlockVaule("•Енергія гравця: ", this.energy, color2: ConsoleColor.Cyan);
            showInfoBlockVaule("•Сила гравця: ", this.power, color2: ConsoleColor.Green);
            showInfoBlockVaule("•Спритність гравця: ", this.agility, color2: ConsoleColor.DarkCyan);
            showInfoBlockVaule("•Витривалість гравця: ", this.endurance, color2: ConsoleColor.Magenta);
            showInfoBlockVaule("•Броня гравця: ", this.armor, color2: ConsoleColor.DarkGray);
            showInfoBlockVaule("•Зброя гравця: ", 0, color2: ConsoleColor.DarkGray);
            showInfoBlockVaule("•Рівень гравця: ", this.level, color2: ConsoleColor.DarkYellow);
            showInfoBlockVaule("•Кількість очків досвіду гравця: ", this.numberOFEP, color2: ConsoleColor.DarkBlue);
            showInfoBlockText("•Ім’я гравця: ", this.name, color2: ConsoleColor.Blue);
        }
        public void showInfoEnemy()
        {
            showInfoBlockVaule("•Здоров'я ворога: ", this.health, color2: ConsoleColor.Red);
            showInfoBlockVaule("•Енергія ворога: ", this.energy, color2: ConsoleColor.Cyan);
            showInfoBlockVaule("•Сила ворога: ", this.power, color2: ConsoleColor.Green);
            showInfoBlockVaule("•Спритність ворога: ", this.agility, color2: ConsoleColor.DarkCyan);
            showInfoBlockVaule("•Витривалість ворога: ", this.endurance, color2: ConsoleColor.Magenta);
            showInfoBlockVaule("•Броня ворога: ", this.armor, color2: ConsoleColor.DarkGray);
            showInfoBlockVaule("•Рівень ворога: ", this.level, color2: ConsoleColor.DarkYellow);
            showInfoBlockVaule("•Кількість очків досвіду ворога: ", this.numberOFEP, color2: ConsoleColor.DarkBlue);
            showInfoBlockText("•Ім’я ворога: ", this.name, color2: ConsoleColor.Blue);
        }
    }
}

using GameConsole2023.Creaturs.NPC;
using GameConsole2023.GameEngine;
using GameConsole2023.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameConsole2023.GameInterface.ISkill.SkillInterface;

namespace GameConsole2023.Skills.SkillTank
{
    internal class SkillTank
    {
        public class PowerBlow : CombattSkill, IUseCombatSkill
        {
            public PowerBlow()
            {
                this.name = "PowerBlow";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 110);
                Console.WriteLine("Зараз як ударю!");
            }
        }//Силовий удар (Tank)
        public class PowerGrip : CombattSkill, IUseCombatSkill
        {
            public PowerGrip()
            {
                this.name = "PowerGrip";
            }
            public void useSkill(Enemy mob)
            {                
                mob.setHealth(mob.getHealth() - 150);
                mob.setEnergy(mob.getEnergy() - 35);
                Console.WriteLine("Тікай з дороги!");      
            }
        } //Силовий хват (Tank)
        public class DoubleEdge : CombattSkill, IUseCombatSkill
        {
            public DoubleEdge()
            {
                this.name = "DoubleEdge";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 175);
                mob.setAgility(mob.getAgility() - 15);
                Console.WriteLine("Іди сюда!");
            }
        }//Гострий удар (Tank)
        public class Backstab : CombattSkill, IUseCombatSkill
        {
            public Backstab()
            {
                this.name = "Backstab";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 50);
                mob.setEnergy(mob.getEnergy() - 0.5);
                Console.WriteLine("Хіча!");
            }
        } //Удар в спину (Barbarian, Tank, Rogue)
    }
}

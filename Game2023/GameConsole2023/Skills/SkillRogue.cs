using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameConsole2023.GameInterface.ISkill.SkillInterface;

namespace GameConsole2023.Skills.SkillRogue
{
    internal class SkillRogue
    {
        public class Theft : CombattSkill, IUseCombatSkill
        {
            public Theft()
            {
                this.name = "Theft";
            }
            public void useSkill(Enemy mob)
            {
                mob.setEnergy(mob.getEnergy() - 5); //і ще тут буде краща монет
                Console.WriteLine("Давай сюди свої монети!");
            }
        }//Крадіжка (Rogue)
        class Backstab : CombattSkill, IUseCombatSkill
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

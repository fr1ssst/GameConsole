using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Skills;
using System;
using static GameConsole2023.GameInterface.ISkill.SkillInterface;

namespace GameConsole2023.Skills.SkillBarbarian
{
    internal class SkillBarbarian
    {
        public class Noose : CombattSkill, IUseCombatSkill
        {
            public Noose()
            {
                this.name = "Noose";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 100);
                Console.WriteLine("Оп-оп!");
            }
        }//Петля (Barbarian)
        public class IronGrip : CombattSkill, IUseCombatSkill
        {
            public IronGrip()
            {
                this.name = "IronGrip";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 200);
                mob.setEnergy(mob.getEnergy() - 40);
                Console.WriteLine("З'їж мого залізного кулака!");
            }
        }//Залізна хватка (Barbarian)

        public class BloodyCross : CombattSkill, IUseCombatSkill
        {
            public BloodyCross()
            {
                this.name = "BloodyCross";
            }
            public void useSkill(Enemy mob)
            {
                mob.setHealth(mob.getHealth() - 300);
                mob.setEndurance(mob.getEndurance() - 50);
                mob.setPower(mob.getPower() - 15);
                Console.WriteLine("Чик-чик-чик");
            }
        }//Кривавий Хрест (Barbarian)    
    }
}

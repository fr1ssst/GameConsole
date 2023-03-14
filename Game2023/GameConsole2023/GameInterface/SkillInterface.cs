using GameConsole2023.Creaturs.NPC;
using System;

namespace GameConsole2023.GameInterface.ISkill
{
    internal class SkillInterface
    {
        public interface IUseCombatSkill
        {
            string getName();
            void useSkill(Enemy mob);
        }
    }
}

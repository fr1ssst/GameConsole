using static GameConsole2023.Skills.SkillBarbarian.SkillBarbarian;
using static GameConsole2023.Skills.SkillRogue.SkillRogue;
using static GameConsole2023.Skills.SkillTank.SkillTank;


using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using GameConsole2023.Creaturs.Heroes;
using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Creaturs;
using GameConsole2023.Potions;
using GameConsole2023.GameInterface;
using GameConsole2023.Items;
using GameConsole2023.Different;

namespace GameConsole2023.GameEngine
{
    class Engine
    {
        Random random = null;
        Engine engine = null;

        public int reedem = 0;
        public Enemy enemy = null;
        DifferentSeatings different = new DifferentSeatings();

        public BasePersone player = null;
        public Enemy CreateEnemy()
        {
            random = new Random();
            string[] namesEnemy = { "Перрі", "Ренні", "Джин", "Томі", "Ден", "Круз", "Рей", "Дел", "Шон", "Горен", "Дрейк" };

            enemy = new Enemy(namesEnemy[this.random.Next(0, namesEnemy.Length)], 1);
            return enemy;
        }
        public BasePersone CreatePlayer()
        {
            engine = new Engine();
            random = new Random();

            string[] names = { "Зевс", "Посейдон", "Аїд",
                " Гера", "Деметра", "Гестія",
            "Афіна", "Афродіта", "Аполлон", "Артеміда", "Гефест", "Арес",
                "Олімпастер"};

            different.showText("\nВиберіть клас гравця: ", ConsoleColor.White);
            different.showText("[1] Варвар", ConsoleColor.DarkCyan);
            different.showText("[2] Танк", ConsoleColor.Red);
            different.showText("[3] Розбійник", ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.White;
            reedem = Convert.ToInt32(Console.ReadLine());

            switch (reedem)
            {
                case 1:
                    player = new Barbarian(names[random.Next(0, names.Length)]);

                    different.showText("\nДобре ви вибрали клас гравця - Варвар", ConsoleColor.DarkCyan);

                    player.addSkill(new Noose());
                    player.addSkill(new IronGrip());
                    player.addSkill(new BloodyCross());
                    player.addSkill(new Backstab());

                    break;
                case 2:
                    player = new Tank(names[random.Next(0, names.Length)]);

                    different.showText("\nДобре ви вибрали клас гравця - Танк", ConsoleColor.Red);

                    player.addSkill(new PowerBlow());
                    player.addSkill(new PowerGrip());
                    player.addSkill(new DoubleEdge());
                    player.addSkill(new Backstab());

                    break;
                case 3:
                    player = new Rogue(names[random.Next(0, names.Length)]);

                    different.showText("\nДобре ви вибрали клас гравця - Розбійник", ConsoleColor.Green);

                    player.addSkill(new Theft());
                    player.addSkill(new Backstab());

                    break;
                default:
                    different.showText("\n[Error] Такої опції немає", ConsoleColor.DarkRed);
                    break;
            }
            player.addPoition(new HealthPotion(10));
            player.addPoition(new HealthPotion(10));
            player.addPoition(new HealthPotion(10));
            Thread.Sleep(1000);
            return player;           
        }      
    }
}

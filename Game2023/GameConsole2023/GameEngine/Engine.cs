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

namespace GameConsole2023.GameEngine
{
    internal class Engine
    {
        public int reedem = 0;
        public Enemy enemy = null;
        public BasePersone player = null;
        public void CreateEnemy()
        {
            Random random = new Random();

            string[] namesEnemy = { "Перрі", "Ренні", "Джин", "Томі", "Ден", "Круз", "Рей", "Дел", "Шон", "Горен", "Дрейк" };

            enemy = new Enemy(namesEnemy[random.Next(0, namesEnemy.Length)], 1);
        }
        public void CreatePlayer()
        {
            Random random = new Random();
            void showMenuCP(string text, ConsoleColor color = ConsoleColor.Red)
            {
                Console.ForegroundColor = color;
                Console.Write(text);

                Console.WriteLine();
            }

            string[] names = { "Зевс", "Посейдон", "Аїд",
                " Гера", "Деметра", "Гестія",
            "Афіна", "Афродіта", "Аполлон", "Артеміда", "Гефест", "Арес",
                "Олімпастер"};

            showMenuCP("\nВиберіть клас гравця: ", ConsoleColor.White);
            showMenuCP("[1] Варвар", ConsoleColor.DarkCyan);
            showMenuCP("[2] Танк", ConsoleColor.Red);
            showMenuCP("[3] Розбійник", ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.White;
            reedem = Convert.ToInt32(Console.ReadLine());

            switch (reedem)
            {
                case 1:

                    player = new Barbarian(names[random.Next(0, names.Length)]);

                    showMenuCP("\nДобре ви вибрали клас гравця - Варвар", ConsoleColor.DarkCyan);

                    player.addSkill(new Noose());
                    player.addSkill(new IronGrip());
                    player.addSkill(new BloodyCross());
                    player.addSkill(new Backstab());

                    break;
                case 2:
                    player = new Tank(names[random.Next(0, names.Length)]);

                    showMenuCP("\nДобре ви вибрали клас гравця - Танк", ConsoleColor.Red);

                    player.addSkill(new PowerBlow());
                    player.addSkill(new PowerGrip());
                    player.addSkill(new DoubleEdge());
                    player.addSkill(new Backstab());

                    break;
                case 3:
                    player = new Rogue(names[random.Next(0, names.Length)]);

                    showMenuCP("\nДобре ви вибрали клас гравця - Розбійник", ConsoleColor.Green);

                    player.addSkill(new Theft());
                    player.addSkill(new Backstab());

                    break;
                default:
                    showMenuCP("\n[Error] Такої опції немає", ConsoleColor.DarkRed);
                    break;
            }
            player.addPoition(new HealthPotion(10));
            player.addPoition(new HealthPotion(10));
            player.addPoition(new HealthPotion(10));

            Thread.Sleep(1000);
        }
        public static void CreateWeapons()
        {
            string[] namesColdWeapon = {"Кинжал", "Спис", "Сковорідка",
                "Булава", "Топор", "Катана" };
            string[] namesWeaponFirearm = {"RPG-7", "Glock-18", "АК-47", "AK-74",
                "UMP-45", "M4А1", "HMG-Dragunov", "Benelli Nova", "SR-Dragunov ",
            "Negev"};
            string[] namesGrenade = {"Осколочна граната", "Коктейль-молотов",
            "Магічна граната"};
        }
        public static void CreateArmors()
        {
            string[] namesArmor = { "Металева броня", "Кольчужна броня", "Титанова броня", "", "", "" };
        }
    }
}

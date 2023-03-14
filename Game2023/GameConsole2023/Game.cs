using System;
using System.Threading;

using GameConsole2023.Skills;
using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Creaturs.Heroes;
using GameConsole2023.GameInterface.ISkill;
using GameConsole2023.GameEngine;
using GameConsole2023.Different;

namespace GameConsole2023
{
    /*
    1. Битви будемо проводити через if({} [>, <, ==] {})
    1.1 Наприлад якщо здоров'я Player дорівнює 10 а здоров'я Enemy дорівнює 13, то додаємо 1 бал Enemy, і наоборот 
    1.2 Якщо енергія Player дорівнює 5 а енергія Enemy дорівнює 7, то додаємо 1 бал Enemy, і наоборот 
    1.3 Якщо сила Player дорівнює 13 а сила Enemy дорівнює 14, то додаємо 1 бал Enemy, і наоборот 
    1.4 Якщо спритність + витривалість Player дорівнює 3 + 7 а броня Enemy дорівнює 11, то додаємо 1 бал Enemy, і наоборот 
    1.5 Якщо рівень Player дорівнює 7 а рівень Enemy дорівнює 8, то додаємо 1 бал Enemy, і наоборот 
    1.6 Якщо КОД Player дорівнює 23 а КОД Enemy дорівнює 27, то додаємо 1 бал Enemy, і наоборот 

    2. Або це все вирішувати формулою int winPlayer = 
    int winEnemy = healthEnemy + energyEnemy + powerEnemy + armorEnemy + levelEnemy + numberOFEPEnemy

    3. Enemy всі зміні будуть рандомні
    3.1 Player буде мати 3 класи варвар, танк, розбійник. Кожен з цих класів буде мати свої значення у змінних
    Наприклад:
    Клас: Варвар
    Здоров'я: 10 
    І т.д.
    3.2 Можна буде вибирати в Menu як буде проходити гра: 
    1) Рандом (Player буде мати рандомні, також він буде мати рандомні класи, значення як і Enemy)
    2) За замовчуванням (Player буде мати класи варвар, танк, розбійник і в кожного класу буде свої значення а в Еnemy буде мати рандомні значення)
    3) Хард режим (Enemy буде мати свої зміні указані в коді, а Player, буде мати рандомні значення)

    */
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DifferentClases different = new DifferentClases();

            Engine engine = new Engine();

            //different.Menu();
            different.History();

            engine.CreatePlayer();
            engine.CreateEnemy();

            while (engine.enemy.getHealth() > 0)
            {
                Console.Clear();
                engine.player.showInfoPlayer();
                different.DrawLine();
                engine.enemy.showInfoEnemy();

                engine.player.showSkillList();

                engine.player.useSkill(Convert.ToInt32(Console.ReadLine()), engine.enemy);
                Thread.Sleep(1000);
            }
        }
    }
}
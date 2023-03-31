using GameConsole2023.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using GameConsole2023.Creaturs;
using GameConsole2023.Potions;
using GameConsole2023.Creaturs.NPC;

namespace GameConsole2023.Different
{
    internal class Events
    {
        Random rnd = new Random();
        Engine engine = null;
        DifferentSeatings different = null;

        BasePersone player = null;
        Enemy enemy = null;

        public void Shop()
        {
            engine = new Engine();
            different = new DifferentSeatings();
            
            int menu = 0;
            int buy = 0;

            different = new DifferentSeatings();
            Console.Clear();
            different.showText("~~~Магазин~~~");
            different.showText("[1]Купити зброю", ConsoleColor.Blue);
            different.showText("[2]Купити броню", ConsoleColor.Green);
            different.showText("[3]Купити бафи", ConsoleColor.Cyan);
            different.showText("[9]Перейти в іншу кінмату", ConsoleColor.Magenta);
            menu = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000);

            switch (menu)
            {
                case 1:
                    Console.Clear();
                    different.showText("~~~Лавка зі зброєю~~~", ConsoleColor.Blue);
                    different.showText("[1]Кинжал", ConsoleColor.Red);
                    different.showText("[2]Спис", ConsoleColor.Cyan);
                    different.showText("[3]Сковорідка", ConsoleColor.White);
                    different.showText("[4]Булава", ConsoleColor.Green);
                    different.showText("[5]Топор", ConsoleColor.DarkGreen);
                    different.showText("[6]Катана", ConsoleColor.Yellow);
                    different.showText("[9]Перейти в іншу кінмату", ConsoleColor.Magenta);

                    buy = Convert.ToInt32(Console.ReadLine());
                    if (buy == 1)
                    {
                        different.showText("Ви купили кинжал", ConsoleColor.Red);
                    }
                    else 
                    {
                        Console.WriteLine(buy);
                    }             
                    break;
                case 2:
                    Console.Clear();
                    different.showText("~~~Лавка з бронею~~~", ConsoleColor.Blue);
                    different.showText("[1]Металева броня", ConsoleColor.Red);
                    different.showText("[2]Кольчужна броня", ConsoleColor.Cyan);
                    different.showText("[3]Титанова броня", ConsoleColor.White);
                    different.showText("[9]Перейти в іншу кінмату", ConsoleColor.Magenta);
                    break;
                case 3:
                    Console.Clear();
                    different.showText("~~~Лавка з бафами~~~", ConsoleColor.Blue);
                    different.showText("[9]Перейти в іншу кінмату", ConsoleColor.Magenta);
                    break;
                case 9:
                    Thread.Sleep(1000);
                    different.RunNextRoom();
                    break;
                default:
                    different.showText("[-]Error[-]", ConsoleColor.Red);
                    return;                   
                    //different.RunNextRoom();
            }
            Console.ReadLine();
        }
        public BasePersone Adventure() 
        {

            engine = new Engine();
            rnd = new Random();
            int v = rnd.Next(1, 9);
            different = new DifferentSeatings();
            player = engine.CreatePlayer();
            Console.Clear();
            if (v == 1)
            {
                different.showText("Ай, боляче!", ConsoleColor.Red);
                player.setHealth(player.getHealth() - 20);
            }
            else if (v == 2)
            {
                different.showText("Фух, щось я не такий виносливий як раніше." +
                    "\n", ConsoleColor.DarkCyan);
                player.setEndurance(player.getEndurance() - 5);
                player.setHealth(player.getHealth() - 10);
            }
            else if (v == 3)
            {
                different.showText("Щось я втомився.", ConsoleColor.Cyan);
                player.setEnergy(player.getEnergy() - 15);
            }
            else if (v == 4)
            {
                different.showText("Ей, а де моє золото?!", ConsoleColor.Yellow);
                player.setCoin(player.getCoin() - 3);
            }
            else if (v == 5)
            {
                different.showText("Ура, я підвищив свій рівень!", ConsoleColor.DarkYellow);
                player.setLevel(player.getLevel() + 1);
            }
            else if (v == 6)
            {
                different.showText("Ура, я багатий!", ConsoleColor.Yellow);
                player.setCoin(player.getCoin() + 4);
            }
            else if (v == 7)
            {
                different.showText("Якщо не постаратися, здоров'я не купити.", ConsoleColor.Red);
                player.setHealth(player.getMaxHp() + 15);
            }
            else if(v == 8) 
            {
                different.showText("Я швидкість!", ConsoleColor.Green);
                player.setAgility(player.getAgility() + 15);
            }
            player.showInfoPlayer();
            different.DrawLine();
            Thread.Sleep(1000);

            different.PressEnterRoom();
            different.RunNextRoom();
            return player;
        }       
        public void EmptyRoom() 
        {
            different = new DifferentSeatings();
            Console.Clear();
            different.showText("[----------------]" +
                "\n[Ця кімната пуста]" +
                "\n[----------------]", ConsoleColor.Cyan);
            different.PressEnterRoom();
            different.RunNextRoom();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Shop
{
    internal class GameShop
    {
        private int coin = 0;
        private static void showText(string text, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
        public static void ShopMenu()
        {
            showText("~~~Магазин~~~");
            showText("[1]Купити зброю", ConsoleColor.Blue);
            showText("[2]Купити броню", ConsoleColor.Green);
            showText("[3]Купити бафи", ConsoleColor.Magenta);
        }
    }
}

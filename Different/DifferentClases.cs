using System;
using System.Threading;

namespace GameConsole2023.Different
{
    internal class DifferentClases
    {
        public void showText(string text, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
            //Console.ReadKey();
        }

        public void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
        }
        public void Menu()
        {
            DrawLine();
        }
        public void PressEnter()
        {
            showText("\nНатисніть Enter - щоб продовжити;", ConsoleColor.DarkMagenta);
            Console.ReadKey();
            Thread.Sleep(700);
        }
        public void History()
        {
            showText("Це було приблизно VII століттях до н. е." +
                "\nКоли ще на горі Фессалії жили давньогрецькі боги. Місце на тій горі було красиве, не можна було передати словами. " +
                "\nАле насправді так круто не було..." +
                "\nЛюди - це ті створіння, які хотіли більше влади. " +
                "\nА щоб її здобути цю владу, вони робили війни. " +
                "\nІ повстали вони проти грецьких Богів...які на той момент сиділи і жаліли що зробили таких потворних людей...");

            Thread.Sleep(1000);
            PressEnter();
        }
    }
}

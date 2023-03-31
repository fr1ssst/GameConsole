using System;
using System.Text;
using GameConsole2023.Creaturs;
using GameConsole2023.Creaturs.Heroes;
using GameConsole2023.Creaturs.NPC;
using GameConsole2023.Skills;


namespace GameConsole2023.GameInterface
{
    interface IUsePotion
    {
        string getNamePotion();
        void UsePotion(BasePersone persone);

        /*
         Бафи: 
        [0]Баф Здоров'я
        +Дай 30 здоров'я, 5 енергії, 1 броні
        [1]Баф Сили 
        +Дає 15 здоров'я, 10 сили, 2 броні
        [2]Баф Енергії
        +Дає 15 енергії, 1 спритність, 2 витривалості, 95 очків досвіду
        [3]Баф Спритності
        +Дає 3 спритності, 5 витривалості, 5 здоров'я
         */
    }
}
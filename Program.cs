using System;
using rpg_game.src;
using rpg_game.src.Entities;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(7));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate a random number.  
            // Call Scenairo method based on random number generated
            Random random = new Random();
            int shipPlacement = random.Next(1, 10);


            Console.Title = "C#Ship!";
            Console.WriteLine("Welcome to C#Ship!\r\n\r\n");
            Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            Console.WriteLine();
            BattleshipBoard b = new BattleshipBoard();
            Player p = new Player();

            if(shipPlacement <= 5)
            {
                p.Scenairo1();
            }
            else
            {
                p.Scenairo2();
            }

            // p.Scenairo1();
            while (p.getHitCount() < 17)
            {
                b.DisplayBoard(p.GetGrid());
                p.AskCoordinates();
            }
            Console.WriteLine("===============================================\n\n\n\n");
            Console.WriteLine("Congratulations, " + name + "! You Win!\r\n");
            Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
            Console.WriteLine("Thanks for playing C#Ship! Press enter to quit.");
            Console.WriteLine("\n\nCopyright(c)2017 VG Inc.\n\n===============================================");
            System.Console.ReadLine();
        }


    }
}
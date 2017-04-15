using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip_Midterm
{
    class Battleship
    {
        static void Main(string[] args)
        {
            // generate a random number.  
            // Call Scenairo method based on random number generated
            Random random = new Random();
            int shipPlacement = random.Next(1, 7);

            Console.Title = "C#Ship!";
            Console.WriteLine("Welcome to C#Ship!\r\n\r\n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine();

            BattleshipBoard b = new BattleshipBoard();
            PlayerVsComputer p = new PlayerVsComputer();

            if (shipPlacement == 1)
            {
                p.Scenairo1();
            }
            else if (shipPlacement == 2)
            {
                p.Scenairo2();
            }
            else if (shipPlacement == 3)
            {
                p.Scenairo3();
            }
            else if (shipPlacement == 4)
            {
                p.Scenairo4();
            }
            else if (shipPlacement == 5)
            {
                p.Scenairo5();
            }
            else if (shipPlacement == 6)
            {
                p.Scenairo6();
            }
            else
            {
                p.Scenairo7();
            }
            // p.Scenairo1();
            while (p.getHitCount() < 17)
            {
                b.DisplayBoard(p.GetGrid());
                p.AskCoordinates();
            }
            Console.WriteLine("===============================================\n");
            Console.WriteLine("You Win!!!");
            Console.WriteLine($"Congratulations, {name}", "! You Win!\r\n");
            Console.WriteLine($"You missed: {p.getMissCount()}", " times\r\n");
            Console.WriteLine("Thanks for playing C#Ship! Press enter to quit.");
            Console.WriteLine("\n\nCopyright(c)2017 VairGerard Inc.\n");
            Console.WriteLine("===============================================");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Midterm
{
    public class PlayerVsComputer
    {
        // declar variables
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int x = 0;
        int y = 0;
       
        // UI for Battleship!
        public int getHitCount()
        {
            return HitCount;
        }
        public int getMissCount()
        {
            return MissCount;
        }
        public void AskCoordinates()
        {
            Console.WriteLine("Enter X Coordinate for your guess (Horizontal)");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            Console.WriteLine("Enter Y Coordinate for your guess (Vertical)");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }

            try
            {
                if (Grid[x, y].Equals(' '))
                {
                    Grid[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    HitCount += 1;
                }
                else
                {
                    Grid[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    MissCount += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Please enter numbers between 0 and 9. (Inclusive)");
            }
        }
        public char[,] GetGrid()
        {
            return Grid;
        }
        public void SetGrid(int q, int w)
        {
            Grid[q, w] = ' ';
        }
        public void Scenairo1()
        {

            //Destroyer
            SetGrid(1, 2);
            SetGrid(2, 2);

            //Submarine
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

            //Cruiser
            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);

            //Battleship
            SetGrid(0, 8);
            SetGrid(1, 8);
            SetGrid(2, 8);
            SetGrid(3, 8);

            //AirCraftCarrier
            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
        }
        public void Scenairo2()
        {

            //Destroyer
            SetGrid(7, 1);
            SetGrid(7, 2);

            //Submarine
            SetGrid(5, 0);
            SetGrid(5, 1);
            SetGrid(5, 2);

            //Cruiser
            SetGrid(6, 6);
            SetGrid(7, 6);
            SetGrid(8, 6);

            //Battleship
            SetGrid(1, 2);
            SetGrid(1, 3);
            SetGrid(1, 4);
            SetGrid(1, 5);

            //AirCraftCarrier
            SetGrid(0, 3);
            SetGrid(0, 4);
            SetGrid(0, 5);
            SetGrid(0, 6);
            SetGrid(0, 7);
        }
        public void Scenairo3()
        {

            //Destroyer
            SetGrid(7, 9);
            SetGrid(8, 9);

            //Submarine
            SetGrid(0, 3);
            SetGrid(1, 3);
            SetGrid(2, 3);

            //Cruiser
            SetGrid(0, 2);
            SetGrid(1, 2);
            SetGrid(2, 2);

            //Battleship
            SetGrid(0, 1);
            SetGrid(1, 1);
            SetGrid(2, 1);
            SetGrid(3, 1);

            //AirCraftCarrier
            SetGrid(0, 0);
            SetGrid(1, 0);
            SetGrid(2, 0);
            SetGrid(3, 0);
            SetGrid(4, 0);
        }
        public void Scenairo4()
        {
            //Destroyer
            SetGrid(1, 2);
            SetGrid(2, 2);

            //Submarine
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

            //Cruiser
            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);

            //Battleship
            SetGrid(0, 8);
            SetGrid(1, 8);
            SetGrid(2, 8);
            SetGrid(3, 8);

            //AirCraftCarrier
            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
        }
        public void Scenairo5()
        {

            //Destroyer
            SetGrid(7, 1);
            SetGrid(7, 2);

            //Submarine
            SetGrid(4, 0);
            SetGrid(4, 1);
            SetGrid(4, 2);

            //Cruiser
            SetGrid(6, 6);
            SetGrid(7, 6);
            SetGrid(8, 6);

            //Battleship
            SetGrid(1, 3);
            SetGrid(1, 4);
            SetGrid(1, 5);
            SetGrid(1, 6);

            //AirCraftCarrier
            SetGrid(3, 4);
            SetGrid(3, 5);
            SetGrid(3, 6);
            SetGrid(3, 7);
            SetGrid(3, 8);

        }
        public void Scenairo6()
        {

            //Destroyer
            SetGrid(1, 9);
            SetGrid(2, 9);

            //Submarine
            SetGrid(5, 6);
            SetGrid(5, 7);
            SetGrid(5, 8);

            //Cruiser
            SetGrid(2, 4);
            SetGrid(2, 5);
            SetGrid(2, 6);

            //Battleship
            SetGrid(0, 2);
            SetGrid(1, 2);
            SetGrid(2, 2);
            SetGrid(3, 2);

            //AirCraftCarrier
            SetGrid(4, 1);
            SetGrid(4, 2);
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);

        }
        public void Scenairo7()
        {
            //Destroyer
            SetGrid(9, 2);
            SetGrid(9, 3);

            //Submarine
            SetGrid(3, 6);
            SetGrid(4, 6);
            SetGrid(5, 6);

            //Cruiser
            SetGrid(5, 5);
            SetGrid(6, 5);
            SetGrid(7, 5);

            //Battleship
            SetGrid(0, 0);
            SetGrid(1, 0);
            SetGrid(2, 0);
            SetGrid(3, 0);

            //AirCraftCarrier
            SetGrid(4, 9);
            SetGrid(5, 9);
            SetGrid(6, 9);
            SetGrid(7, 9);
            SetGrid(8, 9);
        }
    }
}
    

    
        
     




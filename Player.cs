using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Player
    {
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        int x = 0;
        int y = 0;

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
                if (Grid[x, y].Equals('s'))
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
            Grid[q, w] = 's';
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
            SetGrid(9, 2);
            SetGrid(9, 3);

          
        }

    }

}

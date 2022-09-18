using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayBootCamp
{
    // X, O
    class TicTacToe
    {
        // variables...
        static char[] array = {'0', '1', '2', '3', '4', '5' , '6', '7', '8', '9' };
        static bool gameOver = false;
        static bool turnX = true;
        static void DrawBoard()
        {
            Console.Clear();
            Console.Write(array[1] + "    |   ");
            Console.Write(array[2] + "    |   ");
            Console.WriteLine(array[3]);
            Console.WriteLine("_____|________|_____");
            Console.Write(array[4] + "    |   ");
            Console.Write(array[5] + "    |   ");
            Console.WriteLine(array[6]);
            Console.WriteLine("_____|________|_____");
            Console.Write(array[7] + "    |   ");
            Console.Write(array[8] + "    |   ");
            Console.WriteLine(array[9]);
            
        }

        static void UserSelection()
        {
            if (turnX == true)
            {
                Console.WriteLine("Player 1");
            }
            else
            {
                Console.WriteLine("Player 2");
            }
                
            Console.WriteLine("Enter Spot #");
            int spot = Convert.ToInt32(Console.ReadLine());

            if(turnX == true)
            {
                array[spot] = 'X';
                turnX = false;
            }
            else
            {
                array[spot] = 'O';
                turnX = true;
            }
        }
        
        // Winner checking
        static char CheckWinner()
        {
            if(array[1] == array[2] && array[2] == array[3])
            {
                gameOver = true;
                return array[1];
            }
            else if(array[4] == array[5] && array[5] == array[6])
            {
                gameOver = true;
                return array[4];
            }
            else if (array[7] == array[8] && array[8] == array[9])
            {
                gameOver = true;
                return array[7];
            }
            // columns....
            else if (array[1] == array[4] && array[4] == array[7])
            {
                gameOver = true;
                return array[1];
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                gameOver = true;
                return array[2];
            }
            else if (array[3] == array[6] && array[6] == array[9])
            {
                gameOver = true;
                return array[3];
            }
            else if (array[1] == array[5] && array[5] == array[9])
            {
                gameOver = true;
                return array[1];
            }
            else if (array[3] == array[5] && array[5] == array[7])
            {
                gameOver = true;
                return array[3];
            }
            return '0';
        }
        
        // Main Method below;
        static void Main(string[] args)
        {
            DrawBoard();
            // Input from both users...
            while (gameOver == false)
            {
                UserSelection();
                DrawBoard();
                // Check if someone is winner...
                char winner = CheckWinner();// X, O or 0
                if (winner != '0' && winner == 'X')
                {
                    Console.WriteLine("Game is Over! Winner is Player 1");
                }
                else if (winner != '0' && winner == 'O')
                {
                    Console.WriteLine("Game is Over! Winner is Player 2");
                }
            }// end of while loop
        }


    }
}

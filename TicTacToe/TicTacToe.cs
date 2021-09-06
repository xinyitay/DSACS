using System;
using System.Linq;

namespace TicTacToeAssig
{
    public static class TicTacToe
    {
        static char player = 'X';
        static int count = 0;

        public static void OutputState(char[,] state)
        {

            char[,] arr = new char[3, 3];

            //GetLength(0) = no rows
            //GetLength(1) = no cols
            for (int i = 0; i < state.GetLength(0); i++)
            {
                for (int j = 0; j < state.GetLength(1); j++)
                {
                    arr[i, j] = state[i, j];                 
                }
                
            }

            // deduce state above and print appropriate output
            if (!checkWin(arr))
            {
                PlayerTurn(player);
            }
            else
            {
                Won(player);
            }                        
         
        }
              
        public static bool checkWin(char[,] arr)
        {
            //// new board
            //char[,] hello = new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } };
            
            //if (arr.SequenceEqual(new char[,] { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } }))
            //{
            //    return false;
            //}


            // horizontal win 
            if ((arr[0, 0] == arr[0,1] && arr[0, 1] == arr[0, 2] && arr[0, 0] != '.') ||
                    (arr[1, 0] == arr[1, 1] && arr[1, 1] == arr[1, 2] && arr[1, 0] != '.' ) ||
                    (arr[2, 0] == arr[2, 1] && arr[2, 1] == arr[2, 2] && arr[2, 2] != '.'))
            {
                return true;
            }

            // vertical win
            if ((arr[0, 0] == arr[1, 0] && arr[1, 0] == arr[2, 0] && arr[0, 0] != '.') ||
                   (arr[0, 1] == arr[1, 1] && arr[1, 1] == arr[2, 1] && arr[0, 1] != '.') ||
                   (arr[0, 2] == arr[1, 2] && arr[1, 2] == arr[2, 2] && arr[0, 2] != '.'))
            {
                return true;
            }

            // diagonal win
            if ((arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2] && arr[0, 0] != '.') ||
                   (arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0] && arr[0, 2] != '.'))                   
            {
                return true;
            }
            count++;
            return false;
        }
                  
        public static void Won(char player)
        {
            Console.WriteLine($"{player} won.");
            count = 0;
        }
              

        public static void PlayerTurn(char player)
        {
            if (count % 2 != 0)
            {
                // currently player X. switch to O
                // implement error checking later
                player = 'O';
            } else
            {
                // currently player O. switch to X
                player = 'X';
            }
      
                Console.WriteLine($"{player}'s turn.");
            }
            
        }
                 
}

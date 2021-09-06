using System;

namespace TicTacToeAssig
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample state
            //char[,] state1 = { { 'O', '.', 'X' }, { '.', 'O', 'X' }, { '.', '.', 'X' } };
            //TicTacToe.OutputState(state1);

            // horizontal win
            char[,] h = { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } };
            TicTacToe.OutputState(h);

            char[,] h1 = {  { '.', '.', 'X' }, { '.', '.', '.' }, { '.', '.', '.'} };
            TicTacToe.OutputState(h1);

            char[,] h2 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            TicTacToe.OutputState(h2);

            char[,] h3 = { { 'X', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            TicTacToe.OutputState(h3);

            char[,] h4 = { { 'X', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', 'O' } };
            TicTacToe.OutputState(h4);

            char[,] h5 = { { 'X', 'X', 'X' }, { '.', 'O', '.' }, { '.', '.', 'O' } };
            TicTacToe.OutputState(h5);

  

            // vertical win 
            char[,] v1 = { { '.', '.', 'X' }, { '.', '.', '.' }, { '.', '.', '.' } };
            TicTacToe.OutputState(v1);

            char[,] v2 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            TicTacToe.OutputState(v2);

            char[,] v3 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', 'X' } };
            TicTacToe.OutputState(v3);
            
            char[,] v4 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', 'O', 'X' } };
            TicTacToe.OutputState(v4);

            char[,] v5 = { { '.', '.', 'X' }, { '.', 'O', 'X' }, { '.', 'O', 'X' } };
            TicTacToe.OutputState(v5);

        }
    }
}

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

            //char[,] h1 = { { '.', '.', '.' }, { '.', '.', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(h1);

            //char[,] h2 = { { '.', '.', 'X' }, { '.', '.', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(h2);

            //char[,] h3 = { { 'X', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(h3);

            //char[,] h4 = { { 'X', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', 'O' } };
            //TicTacToe.OutputState(h4);

            //char[,] h5 = { { 'X', 'X', 'X' }, { '.', 'O', '.' }, { '.', '.', 'O' } };
            //TicTacToe.OutputState(h5);



            // vertical X win
            //char[,] v1 = { { '.', '.', 'X' }, { '.', '.', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(v1);

            //char[,] v2 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(v2);

            //char[,] v3 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', 'X' } };
            //TicTacToe.OutputState(v3);

            //char[,] v4 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(v4);

            //char[,] v5 = { { '.', '.', 'X' }, { '.', 'O', 'X' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(v5);

            //char[,] vx = { { 'O', '.', 'X' }, { '.', 'O', 'X' }, { '.', '.', 'X' } };
            //TicTacToe.OutputState(vx);


            // vertical O win
            //char[,] vo1 = { { '.', '.', 'X' }, { '.', '.', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(vo1);

            //char[,] vo2 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', '.' } };
            //TicTacToe.OutputState(vo2);

            //char[,] vo3 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', '.', 'X' } };
            //TicTacToe.OutputState(vo3);

            //char[,] vo4 = { { '.', '.', 'X' }, { '.', 'O', '.' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(vo4);

            //char[,] vo5 = { { '.', '.', 'X' }, { 'X', 'O', '.' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(vo5);

            //char[,] vo6 = { { '.', 'O', 'X' }, { 'X', 'O', '.' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(vo6);

            //char[,] invalid = { { 'O', 'X', 'O' }, { 'X', 'O', 'X' }, { 'O', 'X', 'O' } };
            //TicTacToe.OutputState(invalid);

            //char[,] invalid2 = { { 'X', 'O', '.' }, { '.', 'X', 'O' }, { '.', 'O', 'X' } };
            //TicTacToe.OutputState(invalid2);


            //// diagonal O win
            //char[,] dow = { { 'X', '.', 'O' }, { '.', 'O', 'X' }, { 'O', '.', 'X' } };
            //TicTacToe.OutputState(dow);


            //// input 12, expect wait what.
            //char[,] i12 = { { '.', 'O', 'X' }, { 'X', 'O', 'X' }, { 'X', 'O', '.' } };
            //TicTacToe.OutputState(i12);

            //// input 18, expect diagonal O won.
            //char[,] i18 = { { 'X', '.', 'O' }, { '.', 'O', 'X' }, { 'O', '.', 'X' } };
            //TicTacToe.OutputState(i18);

            // input 8
            // need to keep track of 2 wins some how. return invalid.
            char[,] i8 = { { 'O', 'O', 'O' }, { 'X', 'X', 'X' }, { '.', '.', '.' } };
            TicTacToe.OutputState(i8);


            // input 8 modified
            char[,] i8m = { { 'X', 'X', 'X' }, { 'O', 'O', 'O' }, { '.', '.', '.' } };
            TicTacToe.OutputState(i8m);


            ////input 2
            //char[,] i2 = { { 'O', '.', 'X' }, { '.', 'O', 'X' }, { '.', '.', 'X' } };
            //TicTacToe.OutputState(i2);

            //input 19
            //char[,] i19 = { { 'X', 'O', 'X' }, { 'O', 'O', 'X' }, { 'X', 'X', 'O' } };
            //TicTacToe.OutputState(i19);

            ////input 7
            //char[,] i7 = { { '.', 'O', '.' }, { 'X', 'X', '.' }, { '.', '.', 'O' } };
            //TicTacToe.OutputState(i7);



            //char[,] draw = { { 'X', 'O', 'X' }, { 'O', 'X', 'O' }, { 'X', 'O', 'X' } };
            //TicTacToe.OutputState(draw);

        }
    }
}

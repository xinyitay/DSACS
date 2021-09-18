﻿///*
//// Sample code to perform I/O:

//name = Console.ReadLine();                  // Reading input from STDIN
//Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

//// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
//*/

//// Write your code here
//using System;
//using System.Linq;

//namespace TicTacToeAssig
//{
//    class Program
//    {
//        static char player = 'X';
//        static int playerXCount;
//        static int playerOCount;

//        static void Main(string[] args)
//        {


//            char[,] arr = new char[3, 3];
//            string row1 = Console.ReadLine();
//            string row2 = Console.ReadLine();
//            string row3 = Console.ReadLine();

//            for (int i = 0; i < 3; i++)
//            {
//                arr[0, i] = row1[i];
//                arr[1, i] = row2[i];
//                arr[2, i] = row3[i];
//            }

//            // for (int i = 0; i < 3; i++) {
//            //     for (int j = 0; j < 3; j++) {
//            //         Console.WriteLine(arr[i,j]);
//            //     }                
//            // }
//            playerXCount = 0;
//            playerOCount = 0;


//            // deduce state above and print appropriate output
//            if (!checkBoard(arr))
//            {
//                Console.WriteLine("Wait, what?");
//            }
//            else if (checkWin(arr) == '.')
//            {
//                if (playerXCount + playerOCount < 9)
//                {
//                    WhichPlayerTurn();
//                    Console.WriteLine($"{player}'s turn.");
//                }
//                else
//                {
//                    Console.WriteLine("Its a draw.");
//                }
//            }
//            else
//            {
//                if (!checkValidWin(player))
//                {
//                    Console.WriteLine("Wait, what?");
//                }
//                else
//                {
//                    Console.WriteLine($"{player} won.");
//                }
//            }

//        }

//        public static bool checkBoard(char[,] arr)
//        {
//            // check if board has more O than X (not valid)
//            // if not, check if number of X - O > 1 (not valid)
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    if (arr[i, j] == 'X')
//                    {
//                        playerXCount += 1;
//                    }

//                    if (arr[i, j] == 'O')
//                    {
//                        playerOCount += 1;
//                    }
//                }
//            }

//            if (playerOCount > playerXCount)
//            {
//                return false;
//            }

//            if (playerXCount - playerOCount > 1)
//            {
//                return false;
//            }

//            return true;
//        }

//        public static char checkWin(char[,] arr)
//        {
//            // combine diff versions of winning so that only need to obtain player char once

//            // index 0
//            // horizontal win
//            if ((arr[0, 0] == arr[0, 1] && arr[0, 1] == arr[0, 2] && arr[0, 0] != '.') ||
//                // vertical win
//                (arr[0, 0] == arr[1, 0] && arr[1, 0] == arr[2, 0] && arr[0, 0] != '.') ||
//                // diagonal win
//                (arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2] && arr[0, 0] != '.'))
//            {
//                player = arr[0, 0];
//                return arr[0, 0];
//            }

//            // index 1
//            // horizontal win
//            if (arr[1, 0] == arr[1, 1] && arr[1, 1] == arr[1, 2] && arr[1, 0] != '.')
//            {
//                player = arr[1, 0];
//                return arr[1, 0];
//            }

//            // vertical win
//            if (arr[0, 1] == arr[1, 1] && arr[1, 1] == arr[2, 1] && arr[0, 1] != '.')
//            {
//                player = arr[0, 1];
//                return arr[0, 1];
//            }

//            // index 2
//            // horrizontal win
//            if (arr[2, 0] == arr[2, 1] && arr[2, 1] == arr[2, 2] && arr[2, 2] != '.')
//            {
//                player = arr[2, 0];
//                return arr[2, 0];
//            }

//            // vertical win
//            if ((arr[0, 2] == arr[1, 2] && arr[1, 2] == arr[2, 2] && arr[0, 2] != '.') ||
//                // diagonal win
//                (arr[0, 2] == arr[1, 1] && arr[1, 1] == arr[2, 0] && arr[0, 2] != '.'))
//            {
//                player = arr[0, 2];
//                return arr[0, 2];
//            }

//            return '.';
//        }

//        public static bool checkValidWin(char player)
//        {

//            if (player == 'O' && playerXCount > playerOCount)
//            {
//                return false;
//            }

//            if ((player == 'X') && (playerXCount == playerOCount))
//            {
//                return false;
//            }



//            return true;
//        }


//        public static void WhichPlayerTurn()
//        {
//            // buggy: goes here frm win but dk why player changes 2 times. frm X to O to X again.
//            // is it not returned??
//            if (playerXCount > playerOCount)
//            {
//                // currently player X. switch to O                
//                player = 'O';
//            }
//            else
//            {
//                // currently player O. switch to X                           
//                player = 'X';
//            }


//        }
//    }

//}
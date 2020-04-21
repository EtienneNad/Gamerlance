using System;
using Connect4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    class Program
    {
        static void Main(string[] args)
        {
            connect4 game = new connect4();

            char player = '1';
            int column;

            bool gameLoop = true;
            bool inputLoop;

            while (gameLoop)
            {

                System.Console.Clear();
                game.DisplayGrid();

                do
                {
                    inputLoop = true;

                    Console.Write("\nPlayer ");
                    Console.Write(player);
                    Console.Write(": ");

                    if (Int32.TryParse(Console.ReadLine(), out column))
                    {
                        if (1 <= column && column <= 7)
                        {
                            if (game.DropPieceInGrid(player, column))
                            {
                                inputLoop = false;
                            }
                            else
                            {
                                System.Console.Clear();
                                game.DisplayGrid();
                                Console.WriteLine("\nThat column is full.");
                            }
                        }
                        else
                        {
                            System.Console.Clear();
                            game.DisplayGrid();
                            Console.WriteLine("\nThe integer must be between 1 and 7.");
                        }
                    }
                    else
                    {
                        System.Console.Clear();
                        game.DisplayGrid();
                        Console.WriteLine("\nPlease enter an integer.");
                    }
                } while (inputLoop);

                if (game.FourInARow(player))
                {
                    System.Console.Clear();
                    game.DisplayGrid();
                    Console.Write("\nPlayer ");
                    Console.Write(player);
                    Console.Write(" has won!\n");
                    Console.WriteLine("\nPress enter to quit.");
                    gameLoop = false;
                }
                else if (game.GridIsFull())
                {
                    System.Console.Clear();
                    game.DisplayGrid();
                    Console.WriteLine("\nIt is a draw.");
                    Console.WriteLine("\nPress enter to quit.");
                    gameLoop = false;
                }
                else
                {
                    player = player == '1' ? '2' : '1';
                }
                
            }

            Console.ReadKey();
        }
    }
 }

   
   


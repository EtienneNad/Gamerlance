using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] tab2 = new int[3][];


            tab2[0] = new int[3];
            tab2[1] = new int[4];
            tab2[2] = new int[100];
            for (int i = 0; i < tab2.Length; i++)
            {
                //Console.Write("Chiffre({0}): ", i);
                for (int j = 0; j < tab2[i].Length; j++)
                {

                    Console.Write(tab2[i][j] = j);
                    Console.Write(",");
                }
                Console.WriteLine("\n");
            }


            #region 2emePartie
            int[,] abc = new int[10, 10];

            for (int pos = 0; pos < abc.GetLength(0); pos++)
            {
                for (int i = 0; i < abc.GetLength(1); i++)
                {

                    Console.Write("salut" + " " + "Simon" + " ");
                }
                Console.WriteLine();
            }
            #endregion
            char[,,] toto = new char[3, 3, 3];
            for(int z=0; z < toto.GetLength(0); z++)
            {
                Console.Write("d");
                Console.WriteLine(toto[z, z, z]);
            }
            Console.WriteLine("\n");
            for (int x = 0; x < toto.GetLength(0); x++)
            {        
                Console.Write("c");
                    Console.WriteLine(toto[x, x, toto.GetLength(0) - 1 - x]);
                

            }
           Console.WriteLine("\n");
           
            for (int i = 0; i < toto.GetLength(0); i++) 
            {
                Console.Write("b");
                Console.WriteLine(toto[toto.GetLength(0)-1-i , i, i]);
                ;
            }
            Console.WriteLine("\n");
            for (int a = 0; a < toto.GetLength(0); a++)
            {   
                Console.Write("a");
                Console.WriteLine(toto[toto.GetLength(0)-1-a, a, toto.GetLength(0) - 1 - a]);
               
            }
            Console.WriteLine("\n");
              
            Console.ReadLine();

        }


    }

}    
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1_exercices1
{
    class Program
    {

        public static void Main()
        { 
            Console.Write("triangle 1");
            Console.WriteLine("");
             
            {
            int val2 = 1;
            int b = val2;
            int val = 3;
            int a = val;
            for (int i = 0; i < val; i++)
            {
                for (int v = 0; v < b; v++)
                {
                    Console.Write(" ");
                }
                b++;
                
                for (int k = 0; k < a; k++)
                {
                    Console.Write("*");
                }
                a--;
               
                Console.WriteLine("");
                
            }
            Console.Write("triangle2");
            Console.WriteLine("");

            { 
            int val3 = 3;
            int c = val3;
            int val4 = 1;
            int d = val4;

            for (int i = 0; i<val3; i++)
            {
                for (int v = 0; v<c; v++)
                {
                    Console.Write(" ");
                }
                c--;
                for (int k = 0; k<d; k++)
                {
                    Console.Write("*");
                }
                d++;
                
                Console.WriteLine("");
            }
                    Console.Write("triangle3");
                    Console.WriteLine("");
                    {
                        int val5 = 3;
                        int e = val5;
                        int val6 = 1;
                         int f = val6;
                        for (int i = 0; i < val5; i++)
                        {

                            for (int k = 0; k < f; k++)
                            {
                                Console.Write("*");
                            }
                            f++;
                            Console.WriteLine("");
                        }

                        

                    }

                    Console.ReadLine();
                 }
                }
        }
    }
}
           
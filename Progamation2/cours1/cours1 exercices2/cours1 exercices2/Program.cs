using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1_exercices2
{
    class Program
    {

         static void Main()
        {
            int val2 = 5;
            int b = val2;
            int val = 1;
            int a = val;
            for (int i = 0; i < val2; i++)
            {
                for (int v = 0; v < b; v++)
                {
                    Console.Write("-");
                }
                b--;
                for (int k = 0; k < a; k++)
                {
                    Console.Write("*");
                }
                a++;
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1_exercices5
{
    class Program
    {

        static void Main()
        {
            int val2 = 5;
            int b = val2;
            int val = 1;
            int a = val;
            for (int i = 0; i < val; i++)
            {
               
                for (int k = 0; k < val2; k++)
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

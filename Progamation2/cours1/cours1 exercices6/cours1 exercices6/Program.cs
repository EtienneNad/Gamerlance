using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1_exercices6
{
    class Program
    {

        static void Main()
        {
            int val = 5;

            int a = val;

            for (int i = 0; i < val; i++)
            {
                
                for (int k = 0; k < a; k++)
                {
                    Console.Write("*");
                }
                a--;
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
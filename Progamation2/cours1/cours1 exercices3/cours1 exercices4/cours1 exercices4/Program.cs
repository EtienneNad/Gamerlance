using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours1_exercices4
{
    class Program
    {

        static void Main()
        {
           
            int val = 10;
            int a = val;
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < val; k++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours1_Hello_World
{
    class Program
    {
        static int ctotal = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("bonjours! ");
            for(int x=0;x<1000; x++)
            {
                Console.WriteLine("x");

                string variable = Console.ReadLine();

                ushort age = ushort.Parse(variable);


                age += 100;

                Console.WriteLine(age);

                Console.ReadKey();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 13.1f;
            int b = Convert.ToInt32(a);


            float c = 78.6f;
            int d = (int)c;
            Console.WriteLine(d);
            Console.WriteLine(Math.Pow((double)a, (double)c));
            Console.ReadKey();

            string nombreS = Console.ReadLine();
            int nombre = Convert.ToInt32(nombreS);
            double resultat = Math.Pow((double)(++nombre), (double)2);
            Console.WriteLine(resultat);
            Console.ReadKey(); 
                
        }
    }
}

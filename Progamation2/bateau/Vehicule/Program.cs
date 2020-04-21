using Car;
using Plane;
using automobileLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. marque:"+"\n"+"2. type:"+"\n"+"3. noPlaque:"+"\n"+"4. prix:"+"\n");
            Console.WriteLine("bateau");

            Bateau a = new Bateau("Princecraft", "barque");
            a.Eau = ("green bit");
            
            Console.WriteLine(a);
            Console.WriteLine("\n");
            Console.WriteLine("Avion");

            Avion aa= new Avion("Bonbardier","Plane","pl-123", "2333333333$");

            
            Console.WriteLine(aa); 
            Console.WriteLine("\n");
            Console.WriteLine("Auto");

          Auto mo = new Auto("chevrolet", "cruze", "N45 P2K", "23 000$");


            Console.WriteLine(mo);
            Console.ReadLine();

       




        }
    }
}

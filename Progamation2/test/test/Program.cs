using System;
using person;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
             
        {
            

            for (int i = 0; i < 10 ; i++)
            {



                Console.WriteLine("Entrez votre nom SVP");
                string nom = Console.ReadLine();
                Random rnd = new Random();
                int ages = rnd.Next(0, 100);



                Person toto = new Person(nom,ages);             
                
                        toto.SayHi();  

            } 
           
            Console.ReadLine();

        }
    }
}

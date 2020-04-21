using cegepLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegep
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e = new Etudiant("simon", "tousignant");
           
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}

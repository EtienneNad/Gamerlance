using System;
using jeuDeLaVie;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace jeu
{
    class Program
    {
        static void Main(string[] args)
        {
            JeuDeLaVieTable leJeu = new JeuDeLaVieTable();
            Console.WriteLine();
             Console.SetWindowSize(200, 50);
            while (true)
            {
                string affichageBuffer = leJeu.ToString();
                Console.SetCursorPosition(0, 0);
                Console.Write(affichageBuffer);
                leJeu.cycleSuivant();
                Thread.Sleep(50);
                
            }

           

        }
        
    }
}

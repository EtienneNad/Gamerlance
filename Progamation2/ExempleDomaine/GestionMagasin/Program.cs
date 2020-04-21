using ClassLibrary1;
using Magasin_gestion;
using RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasin
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AjouterOption("Engager Employe");
            menu.AjouterOption("Congédier Employe");
            menu.AjouterOption("Faire autre chose");
            int choix = menu.FaireChoix();

            Magasin leMagasin = new Magasin("toto", "545 55e avenue");
           
            Employe unEmploye = new Employe("nom", "adresse","asdf@asdf.ca");

            leMagasin.Engager(unEmploye);




        }
    }
}

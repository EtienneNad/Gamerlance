using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// classe qui permet de faire afficher un menu à l'écran
    /// </summary>
    public class Menu
    {
        private List<string> options;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Menu()
        {
            options = new List<String>();
        }

        public void AjouterOption(string option)
        {
            options.Add(option);
        }

        /// <summary>
        /// Retourne la chaine de caractère avec toutes les options du menu
        /// </summary>
        /// <returns>une chaine de caractère, 1 ligne = 1 option. 1 based.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < options.Count; i++)
            {
                sb.Append(i+1);
                sb.Append(" - ");
                sb.AppendLine(options[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Affiche le menu et demande le choix de l'utilisateur tant que le choix n'est pas valide
        /// </summary>
        /// <returns>retourne le numero de l'option choisie basée sur 1</returns>
        public int FaireChoix()
        {
            int choix;
            bool valide;

            do
            {
                Console.WriteLine(this);
                string input = Console.ReadLine();
               valide = int.TryParse(input, out choix);
            } while (!valide || choix < 1 || choix > options.Count);
            //tant que choix non valide
            return choix;
        }

    }
}

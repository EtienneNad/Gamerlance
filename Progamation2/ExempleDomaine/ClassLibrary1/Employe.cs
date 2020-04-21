using System;
using System.Collections.Generic;
using System.Text;

namespace RH
{
    /// <summary>
    /// Classe qui stock les informations d'un employé de magasin
    /// </summary>
    public class Employe
    {
        private string nom;
        private string noTelephone;
        private string email;

        public static int nombreEmploye;
        public Employe(string nom, string noTelephone, string email)
        {
            this.nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.noTelephone = noTelephone ?? throw new ArgumentNullException(nameof(noTelephone));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            nombreEmploye++;
        }

        public string Nom { get => nom; set => nom = value; }
        public static int NombreEmploye { get => nombreEmploye;}
    }
}

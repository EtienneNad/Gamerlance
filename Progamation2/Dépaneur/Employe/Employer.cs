using System;
using System.Collections.Generic;


namespace Employe
{
    public class Employer
    {
        private string nom;
        private string adresse;
        private string email;

        public Employer(string nom, string adresse, string email)
        {
            this.nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
        }
    }
}

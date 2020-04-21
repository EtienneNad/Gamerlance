using RH;
using System;
using System.Collections.Generic;

namespace Magasin_gestion
{
    public class Magasin
    {
        private string nom;
        private string adresse;
        private List<Employe> rh;

        public Magasin(string nom, string adresse)
        {
            this.nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.adresse = adresse ?? throw new ArgumentNullException(nameof(adresse));
            rh = new List<Employe>();
        }

        public void Engager(Employe employe)
        {
            rh.Add(employe);
        }

        public bool Fonctionnel {
            get { return rh.Count > 0; }
        }
    }
}

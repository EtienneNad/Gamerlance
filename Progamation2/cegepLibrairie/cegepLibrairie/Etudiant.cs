using System;
using System.Diagnostics;

namespace cegepLibrairie
{
    public class Etudiant
    {
        private string nom;
        private string prenom;
        private string da;
        private string codePermanent;

        public Etudiant(string codePermanent)
        {
            this.codePermanent = codePermanent ?? throw new ArgumentNullException(nameof(codePermanent));
           
        }

        public Etudiant(string nom, string prenom)
        {
           
          Nom = nom ;
            this.prenom = prenom ;
        }

        
        public string Nom
        {
            get { return nom; }
            set { this.nom = value; }

        }
        public override string ToString()
        {
            return this.nom+"\n"+ this.prenom;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
   public class Clients : IEquatable<Clients>
        
    {
        private List<Compte> lesCompte = new List<Compte>();
        private string nom;
        private string prenom;

        public Clients(string nom, string prenom)
        {
            this.Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            this.Prenom = prenom ?? throw new ArgumentNullException(nameof(prenom));
            
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public int AjouterCompte(Compte compte)
        {
            lesCompte.Add(compte);
            return lesCompte.Count;

        }
        public int SupprimerCompte(Compte compte)
        {
            foreach(Compte compte1 in lesCompte) { 
            if (compte1.Equals(compte))
            {
            lesCompte.Remove(compte);
            }
            }
            return lesCompte.Count;
        }
        public bool Depot(int montant, Compte compte)
        {
            foreach (Compte compte1 in lesCompte)
            {
                if (compte1.Equals(compte))
                {
                    compte1.Depot(montant);
                    return true;
                }
            }
            return false;
        }
        public bool Retrait(int montant, Compte compte)
        {
            foreach (Compte compte1 in lesCompte)
            {
                if (compte1.Equals(compte))
                {
                    compte1.Retrait(montant);
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Clients))
            {
                return false;
            }
            return Equals(obj as Clients);
        }

        public bool Equals(Clients other)
        {
            return other != null &&
                Nom == nom &&
                Prenom == prenom;
        }

        public override int GetHashCode()
        {
            var hashCode = 1399261157;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            return hashCode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Succusale : IEquatable<Succusale>
    {
        private List<Clients> lesClients = new List<Clients>();
        private uint numSuccursale;
        private string nomSuccursale;

        public Succusale(uint noSuccursale, string nomSuccursale)
        {
            this.numSuccursale = noSuccursale;
            this.nomSuccursale = nomSuccursale ?? throw new ArgumentNullException(nameof(nomSuccursale));
        }

        public string NomSuccursale { get => nomSuccursale; set => nomSuccursale = value; }
        public uint NoSuccursale { get => numSuccursale; set => numSuccursale = value; }

        public int AjouterClient(Clients clients)
        {
            lesClients.Add(clients);
            return lesClients.Count;

        }

        public bool AjouterCompte(Clients clients, Compte compte)
        {
            foreach (Clients client1 in lesClients)
            {

                if (client1.Equals(clients))
                {
                    client1.AjouterCompte(compte);
                    return true;
                }

            }
            return false;

        }
        public int SupprimerClient(Clients clients)
        {
            lesClients.Remove(clients);
            return lesClients.Count;

        }

        public bool SupprimerCompte(Clients clients, Compte compte)
        {
            foreach (Clients client1 in lesClients)
            {

                if (client1.Equals(clients))
                {
                    client1.SupprimerCompte(compte);
                    return true;
                }

            }
            return false;

        }
        public bool Depot(int montant, Clients clients, Compte compte)
        {
            foreach (Clients client1 in lesClients)
            {
                if (client1.Equals(clients))
                {
                    client1.Depot(montant, compte);
                    return true;
                }
            }
            return false;
        }
        public bool Retrait(int montant, Clients clients, Compte compte)
        {
            foreach (Clients client1 in lesClients)
            {
                if (client1.Equals(clients))
                {
                    client1.Retrait(montant, compte);
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
            if (!(obj is Succusale))
            {
                return false;
            }
            return Equals(obj as Succusale);
        }

        public bool Equals(Succusale other)
        {
            return other != null &&
                NoSuccursale == numSuccursale; 
        }

        public override int GetHashCode()
        {
            var hashCode = -1220493097;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomSuccursale);
            hashCode = hashCode * -1521134295 + NoSuccursale.GetHashCode();
            return hashCode;
        }
    }
}

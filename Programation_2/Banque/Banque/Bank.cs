using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Bank

    {
        private List<Succusale> lesSuccursales = new List<Succusale>();
        private uint noBanque;
        private string nomBanque;

        public Bank(uint noBanque, string nomBanque)
        {
            this.noBanque = noBanque;
            this.nomBanque = nomBanque ?? throw new ArgumentNullException(nameof(nomBanque));
        }

        public string NomBanque { get => nomBanque; set => nomBanque = value; }
        public uint NoBanque { get => noBanque; set => noBanque = value; }

        public int AjouterSuccursale(Succusale leSuccursale)
        {
            lesSuccursales.Add(leSuccursale);
            return lesSuccursales.Count;

        }
        public bool AjouterClient(Clients clients, Succusale succusale)
        {
            foreach (Succusale succusale1 in lesSuccursales)
            {

                if (succusale1.Equals(succusale))
                {
                    succusale1.AjouterClient(clients);
                    return true;
                }

            }
            return false;

        }
        public bool AjouterCompte(Clients clients, Compte compte, Succusale succusale)
        {
            foreach (Succusale succursale1 in lesSuccursales)
            {

                if (succursale1.Equals(succusale))
                {
                    succursale1.AjouterCompte(clients, compte);
                    return true;
                }

            }
            return false;
        }

        public bool SupprimerClient(Clients clients, Succusale succusale)
        {
            foreach (Succusale succusale1 in lesSuccursales)
            {

                if (succusale1.Equals(succusale))
                {
                    succusale1.SupprimerClient(clients);
                    return true;
                }

            }
            return false;

        }
        public bool SupprimerCompte(Clients clients, Compte compte, Succusale succusale)
        {
            foreach (Succusale succursale1 in lesSuccursales)
            {

                if (succursale1.Equals(succusale))
                {
                    succursale1.SupprimerCompte(clients, compte);
                    return true;
                }

            }
            return false;
        }
        public bool Depot(int montant, Clients clients, Compte compte, Succusale succursale)
        {
            foreach(Succusale succursale1 in lesSuccursales)
            {
                if (succursale1.Equals(succursale))
                {
                    succursale1.Depot(montant, clients, compte);
                    return true;
                }
            }
            return false;
        }
        public bool Retrait(int montant, Clients clients, Compte compte, Succusale succursale)
        {
            foreach (Succusale succursale1 in lesSuccursales)
            {
                if (succursale1.Equals(succursale))
                {
                    succursale1.Retrait(montant, clients, compte);
                    return true;
                }
            }
            return false;
        } 

    }
}

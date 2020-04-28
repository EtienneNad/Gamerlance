using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    public class Compte
    {
        private uint numCompte;
        private ushort chiffreVerif;
        private int montant;
        

        public Compte(uint noCompte, ushort chiffreVerif, int montant)
        {
            this.numCompte = noCompte;
            this.chiffreVerif = chiffreVerif;
            this.montant = montant;
        }

        public uint NoCompte { get => numCompte; set => numCompte = value; }
        public ushort ChiffreVerif { get => chiffreVerif; set => chiffreVerif = value; }
        public int Montant { get => montant; set => montant = value; }

        public int Depot(int montant)
        {
            Montant += montant;
            return Montant;
        }
        public int Retrait(int montant)
        {
            Montant -= montant;
                return Montant;
           
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Compte))
            {
                return false;
            }
            return Equals(obj as Compte);
        }

        public bool Equals(Compte other)
        {
            return other != null &&
                NoCompte == numCompte;
        }
    }
}

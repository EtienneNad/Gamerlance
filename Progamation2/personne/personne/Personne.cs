using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneClass
{
    public class Personne
    {
        private ushort age;
        private string prenom; 
        private string nom;
        private ushort poid;
        private string da;
        private string codePermanent;

        public Personne()
        {
        }

        /// <summary>
        /// constructeur par defaut "John Doe"
        /// </summary>

        public Personne(ushort age, string prenom, string nom, ushort poid, string da, string codePermanent)
        {///<summary>
        ///constructeur complet
        /// </summary>
        /// <param name="age">age ne peut être <=0</param>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="poid">poid ne peut être <=0</param>
        /// <param name="da"></param> 
        /// <param name="codePermanent"></param>
            if (poid <= 0)
            {
                ArgumentOutOfRangeException uneExeception =
                  new ArgumentOutOfRangeException("poid", "poid inférieur ou égal a 0");
                 
            }
            this.age = age;
            this.prenom = prenom;
            this.nom = nom;
            this.poid = poid;
            this.da = da;
            this.codePermanent = codePermanent;
        }
    }
}

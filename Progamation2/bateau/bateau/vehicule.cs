using System;

namespace automobileLibrairie
{
    public class Bateau
    {
        private string marque;
        private string type;
        private string noPlaque;
        private string prix;

        public Bateau(string prix)
        {
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }

        public Bateau(string marque, string type)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public Bateau(string marque, string type, string noPlaque, string prix)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.noPlaque = noPlaque ?? throw new ArgumentNullException(nameof(noPlaque));
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }
        public string Eau
        {
            get { return marque; }
            set { this.marque = value; }
        }
        public override string ToString()
        {
            return this.marque + "\n" + this.type;
        }
    }
 
   
}

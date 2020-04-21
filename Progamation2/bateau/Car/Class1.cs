using System;

namespace Car
{
    public class Auto
    {
        private string marque;
        private string type;
        private string noPlaque;
        private string prix;

        public Auto(string marque)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
        }

        public Auto(string marque, string prix)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }

        public Auto(string marque, string type, string noPlaque, string prix)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.noPlaque = noPlaque ?? throw new ArgumentNullException(nameof(noPlaque));
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }
        public string Terre
        {
            get { return marque; }
            set { this.marque = value; }
        }
        public override string ToString()
        {
            return this.marque + "\n" + this.type + "\n" + this.prix + "\n" + this.noPlaque;
        }
    }


}

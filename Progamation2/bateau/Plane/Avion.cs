using System;

namespace Plane
{
    public class Avion
    {
        private string marque;
        private string type;
        private string noPlaque;
        private string prix;

        public Avion(string type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public Avion(string type, string prix)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }

        public Avion(string marque, string type, string noPlaque, string prix)
        {
            this.marque = marque ?? throw new ArgumentNullException(nameof(marque));
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.noPlaque = noPlaque ?? throw new ArgumentNullException(nameof(noPlaque));
            this.prix = prix ?? throw new ArgumentNullException(nameof(prix));
        }
        public string air
        {
            get { return marque; }
            set { this.marque = value + value; }
        }
        public override string ToString()
        {
            return this.marque + "\n" + this.noPlaque + "\n" + this.prix;
        }


    }
}

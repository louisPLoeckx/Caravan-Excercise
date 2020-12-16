using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public abstract class Eigendom : IEigendom
    {
        private string eigenaar;

        public string Eigenaar
        {
            get { return eigenaar; }
            private set { eigenaar = value; }
        }

        private double prijs;

        public double Prijs
        {
            get { return prijs; }
            private set 
            {
                if (value>=0)
                {
                   prijs = value;
                }
            }
        }

        public Eigendom(string eigenaar, double prijs)
        {
            Eigenaar = eigenaar;
            Prijs = prijs;
        }

        public void BepaalPrijs(double nieuwePrijs)
        {
            Prijs = nieuwePrijs;
        }

        public void VerkoopAan(string nieuweEigenaar)
        {
            Eigenaar = nieuweEigenaar;
        }

        public override string ToString()
        {
            return $"Naam eigenaar: {Eigenaar} prijs: {Prijs}";
        }

        public int CompareTo(IEigendom eigendom)
        {
            return Prijs.CompareTo(eigendom.Prijs);
        }
    }
}

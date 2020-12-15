using Caravan_Excercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public abstract class Eigendom : IEigendom, IComparable<Eigendom>
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

        public int CompareTo(Eigendom eigendom)
        {
            return this.Prijs.CompareTo(eigendom.Prijs);
        }
        public override string ToString()
        {
            return $"{Eigenaar}: {Prijs}";
        }
    }
}

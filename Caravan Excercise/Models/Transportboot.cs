using Caravan_Excercise.Interfaces;
using System;

namespace Caravan_Excercise.Models
{
    public class Transportboot : Boot, IBelaadbaar
    {
        private bool IsSunk;
        public int HuidigeBelading { get; private set; }
        public int MaximumLaadgewicht { get; private set; }

        public void Laden(int gewicht)
        {
            HuidigeBelading += gewicht;
            if (HuidigeBelading>MaximumLaadgewicht)
            {
                IsSunk = true;
                Snelheid = 0;
                throw new InvalidOperationException("HuidigeBelading is groter dan MaximumLaadgewicht. Schip is gezonken.");
            }
        }

        public Transportboot(int maximumSnelheid, string merk, int snelheid, string eigenaar, double prijs, int maximumLaadgewicht) : base(maximumSnelheid, merk, snelheid, eigenaar, prijs)
        {
            MaximumLaadgewicht = maximumLaadgewicht;
        }

        public void Lossen(int gewicht)
        {
            if (IsSunk)
            {
                throw new InvalidOperationException("Schip is gezonken. Kan niet lossen");
            }
            else
            {
                HuidigeBelading -= gewicht;
            }
        }

        public override void Versnel(int versnelling)
        {
            if (IsSunk)
            {
                throw new InvalidOperationException("Schip is gezonken. Kan niet versnellen");
            }
            else
            {
                base.Versnel(versnelling);
            } 
        }

        public override void Vertraag(int vertraging)
        {
            if (IsSunk)
            {
                throw new InvalidOperationException("Schip is gezonken. Kan niet vertragen");
            }
            else
            {
                base.Vertraag(vertraging);
            }
        }

        public override string ToString()
        {
            return $"Belading: {HuidigeBelading} Maximum laadgewicht: {MaximumLaadgewicht}";
        }
    }
}

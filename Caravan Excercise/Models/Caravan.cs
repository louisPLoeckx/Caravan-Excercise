﻿using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        private int aantalSlaapkamers;
        private double bewoonbaarOppervlakte;

        public int AantalSlaapkamers 
        {
            get 
            {
                return aantalSlaapkamers;
            }
            private set 
            {
                aantalSlaapkamers = 1;
            } 
        }

        public double BewoonbaarOppervlakte 
        {
            get 
            {
                return bewoonbaarOppervlakte;
            }
            private set 
            {
                if (value > -1)
                {
                    bewoonbaarOppervlakte = value;
                }
            } 
        }

        public Caravan(int maximumGewicht, int aantalSlaapkamers, double bewoonbaarOppervlakte, int aantalBanden, int gewicht, string eigenaar, double prijs) :base(maximumGewicht, aantalBanden, gewicht, eigenaar, prijs)
        {
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
            AantalSlaapkamers = aantalSlaapkamers;
        }

        public override string ToString()
        {
            return base.ToString() + $" Bewoonbare oppervlakte: {bewoonbaarOppervlakte} aantal slaapkamers: {aantalSlaapkamers}";
        }
    }
}

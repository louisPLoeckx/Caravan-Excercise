
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Huis : Eigendom,IBewoonbaar
    {
        protected int aantalSlaapkamers;
        protected double bewoonbaarOppervlakte;

        public virtual int AantalSlaapkamers
        {
            get 
            {
                return aantalSlaapkamers;
            }
            protected set 
            {
                if (value >= 0)
                {
                    aantalSlaapkamers = value;
                }
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
                bewoonbaarOppervlakte = value;
            }
        }

        public Huis(int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
        public override string ToString()
        {
            return base.ToString() + $" Aantal slaapkamers: {aantalSlaapkamers} bewoonbare oppervlakte: {bewoonbaarOppervlakte}";
        }
    }
}


using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Huis : Eigendom,IBewoonbaar
    {
        public int aantalSlaapkamers;
        public double bewoonbaarOppervlakte;

        public virtual int AantalSlaapkamers
        {
            get 
            {
                return aantalSlaapkamers;
            }
            set 
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
            set 
            {
                bewoonbaarOppervlakte = value;
            }
        }

        public Huis(int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
    }
}

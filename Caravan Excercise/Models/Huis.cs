
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Huis : IBewoonbaar
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

        public Huis(int aantalSlaapkamers, double bewoonbaarOppervlakte) 
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
    }
}

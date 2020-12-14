using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class WoonBoot : Boot, IBewoonbaar
    {
        public int aantalSlaapkamers;
        public double bewoonbaarOppervlakte;

        public int AantalSlaapkamers 
        {
            get 
            {
                return aantalSlaapkamers;
            }
            set 
            {
                if (value <= 2)
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
                if (value > 0)
                {
                    bewoonbaarOppervlakte = value;
                }
            }
        }

        public WoonBoot(int aantalSlaapkamers, double bewoonbaarOppervlakte, int maximumSnelheid, string merk, int snelheid, string eigenaar, double prijs) :base(maximumSnelheid, merk, snelheid, eigenaar, prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
    }
}

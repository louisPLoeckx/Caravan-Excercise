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
            private set 
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

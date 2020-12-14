using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Motorhome : Auto, IBewoonbaar
    {
        public int aantalSlaapkamer;
        private double bewoonbaarOppervlakte;

        public int AantalSlaapkamers 
        {
            get 
            {
                return aantalSlaapkamer;
            }
            set
            {
                aantalSlaapkamer = 1;
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
                if (value >= 0)
                {
                    bewoonbaarOppervlakte = value;
                }
            }
        }

        public Motorhome(int aantalSlaapkamer, double bewoonbaarOppervlakte, int maximumSnelheid, int snelheid, int maximaalTrekGewicht, string merk, ITrekbaar aanhangwagen, string eigenaar, double prijs) :base(maximumSnelheid, snelheid, maximaalTrekGewicht, merk, aanhangwagen, eigenaar, prijs)
        {
            AantalSlaapkamers = aantalSlaapkamer;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
    }
}

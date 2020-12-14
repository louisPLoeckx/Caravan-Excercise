using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        int aantalSlaapkamers;
        double bewoonbaarOppervlakte;

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

        public Caravan(int aantalSlaapkamers, double bewoonbaarOppervlakte, int aantalBanden, int gewicht, string eigenaar, double prijs) :base(aantalBanden, gewicht, eigenaar, prijs)
        {
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
            AantalSlaapkamers = aantalSlaapkamers;
        }
    }
}

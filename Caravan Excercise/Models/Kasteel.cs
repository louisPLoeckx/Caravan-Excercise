﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public class Kasteel: Huis
    {
        public int aantalSlaapkamersKasteel;

        public override int AantalSlaapkamers 
        {
            get 
            {
                //return aantalSlaapkamersKasteel;
                return aantalSlaapkamers;
            }
            set
            {
                if (value >= 3)
                {
                    //aantalSlaapkamersKasteel = value;
                    aantalSlaapkamers = value;
                }
            }
                
        }

        public Kasteel(int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs):base(aantalSlaapkamers, bewoonbaarOppervlakte, eigenaar, prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
        }
    }
}

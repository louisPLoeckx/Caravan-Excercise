using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public class KoppelExeption : Exception
    {
        public int Snelheid { get; private set; }

        public KoppelExeption(int snelheid,string message)
            :base($"Snelheid : {snelheid} {message}")
        {
            Snelheid = snelheid;
        }
    }
}

using System;

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

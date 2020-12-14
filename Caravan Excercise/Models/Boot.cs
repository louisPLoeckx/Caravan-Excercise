using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public abstract class Boot :Eigendom, IVoertuig
    {
        public int maximumSnelheid;
        public string merk;
        public int snelheid;

        public int MaximumSnelheid
        {
            get
            {
                return maximumSnelheid;
            }
            set
            {
                if (value >= 0)
                {
                    maximumSnelheid = value;
                }
            }
        }

        public string Merk
        {
            get 
            { 
                return merk; 
            }
            set 
            { 
                merk = value; 
            }
        }

        public int Snelheid
        {
            get
            {
                return snelheid;
            }
            set
            {
                if (value >= 0)
                {
                    snelheid = value;
                }
            }
        }

        public virtual void Versnel(int versnelling)
        {
            if (snelheid < maximumSnelheid)
            {
                if (snelheid + versnelling <= maximumSnelheid)
                {
                    snelheid += versnelling;
                }
                else
                {
                    snelheid = maximumSnelheid;
                }
                Console.WriteLine($"Speed {snelheid}km/h");
            }
            else
            {
                Console.WriteLine($"Speed {snelheid}km/h");
                Console.WriteLine("Maximum Speed has already been reached!");
            }
        }

        public virtual void Vertraag(int vertraging)
        {
            if (snelheid > 0)
            {
                if (snelheid - vertraging >= 0)
                {
                    snelheid -= vertraging;

                }
                else
                {
                    snelheid = 0;

                }

                Console.WriteLine($"Speed {snelheid}km/h");

            }
            else
            {
                Console.WriteLine($"Speed {snelheid}km/h");
                Console.WriteLine("The car has stopped and cannot go into reverse");
            };
        }

        public Boot(int maximumSnelheid, string merk, int snelheid, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            MaximumSnelheid = maximumSnelheid;
            Merk = merk;
            Snelheid = snelheid;
        }
    }
}

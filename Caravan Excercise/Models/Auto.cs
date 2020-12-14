using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Auto : IVoertuig, ITrekker
    {
        int maximumSnelheid;
        int snelheid;
        int maximaalTrekGewicht;
        string merk;
        ITrekbaar aanhangwagen;

        public int MaximumSnelheid 
        {
            get 
            {
                return maximumSnelheid;
            }
            private set
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
            private set 
            {
                if (value <= maximumSnelheid)
                {
                    snelheid = value;
                }
            }
        }

        public ITrekbaar Aanhangwagen
        {
            get 
            {
                return aanhangwagen;
            }
            set 
            {
                if (snelheid < 0 || aanhangwagen.Gewicht > MaximaalTrekGewicht)
                {
                    Console.WriteLine("Exception test Aanhangwagen Auto");                    
                    //exception
                }
                else
                {
                    aanhangwagen = value;
                }

            }
        }

        public int MaximaalTrekGewicht 
        {
            get 
            {
                return maximaalTrekGewicht;
            }
            set 
            {
                maximaalTrekGewicht = value;
            }       
        }

        public void KoppelAanhangwagen(ITrekbaar trekbaar)
        {
            if (snelheid == 0 && aanhangwagen.Gewicht <= maximaalTrekGewicht)
            {
                aanhangwagen = trekbaar;//testen
            }
        }

        public void Versnel(int versnelling)
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

        public void Vertraag(int vertraging)
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

        public Auto(int maximumSnelheid, int snelheid, int maximaalTrekGewicht, string merk, ITrekbaar aanhangwagen)
        {
            MaximumSnelheid = maximumSnelheid;
            Snelheid = snelheid;
            MaximaalTrekGewicht = maximaalTrekGewicht;
            Merk = merk;
            Aanhangwagen = aanhangwagen;
        }
    }
}

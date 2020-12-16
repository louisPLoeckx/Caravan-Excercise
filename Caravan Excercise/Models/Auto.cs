using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Interfaces;

namespace Caravan_Excercise.Models
{
    public class Auto : Eigendom, IVoertuig, ITrekker
    {
        private int maximumSnelheid;
        private int snelheid;
        private int maximaalTrekGewicht;
        private string merk;
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
            private set 
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
            private set 
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
            private set 
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
            else if(snelheid != 0)
            {
                throw new KoppelExeption( Snelheid,"Kan geen aanhangwagen koppelen. Snelheid niet 0 ");
            }
            else if (aanhangwagen.Gewicht > maximaalTrekGewicht)
            {
                throw new OverBeladenException(MaximaalTrekGewicht,aanhangwagen.Gewicht,"Kan geen aanhangwagen koppelen. Het gewicht van aanhangwagen is groter dan maximaal trek gewicht");
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

        public Auto(int maximumSnelheid, int snelheid, int maximaalTrekGewicht, string merk,string eigenaar, double prijs):base(eigenaar,prijs)
        {
            MaximumSnelheid = maximumSnelheid;
            Snelheid = snelheid;
            MaximaalTrekGewicht = maximaalTrekGewicht;
            Merk = merk;
        }
        public override string ToString()
        {
            return base.ToString() + $" Maximum trekgewicht: {maximaalTrekGewicht} snelheid: {snelheid} maximumsnelheid: {maximumSnelheid} merk: {merk}.";
        }
    }
}

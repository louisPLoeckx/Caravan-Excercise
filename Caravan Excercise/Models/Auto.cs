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
                    throw new Exception("Exception test Aanhangwagen Auto");                    
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

        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            throw new NotImplementedException();
        }

        public void Versnel(int versnelling)
        {
            throw new NotImplementedException();
        }

        public void Vertraag(int vertraging)
        {
            throw new NotImplementedException();
        }
    }
}

using Caravan_Excercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public class Aanhangwagen : Eigendom, ITrekbaar
    {
        int aantalBanden;
        int gewicht;

        public int AantalBanden 
        { 
            get 
            {
                return aantalBanden;
                
            }
            private set
            {
                if (value >= 2)
                {
                    aantalBanden = value;
                }
                //possibly add an exception try catch
            }
        }
        public int Gewicht 
        {
            get 
            {
                return gewicht;
            }
            private set
            {
                if (value >= 0)
                {
                    gewicht = value;
                }
            }
        }

        public Aanhangwagen(int aantalBanden, int gewicht, string eigenaar, double prijs):base(eigenaar,prijs)
        {
            this.AantalBanden = aantalBanden;
            this.Gewicht = gewicht;
        } 
    }
}

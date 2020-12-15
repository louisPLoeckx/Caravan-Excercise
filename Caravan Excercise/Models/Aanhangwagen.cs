using Caravan_Excercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public class Aanhangwagen : Eigendom, ITrekbaar, IBelaadbaar
    {
        private int aantalBanden;
        private int gewicht;
        public int huidigeBelading;
        public int maximumLaadgewicht;

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
                    gewicht = value + huidigeBelading;
                }
            }
        }



        public int MaximumLaadgewicht { get; set; }
       

        public int HuidigeBelading
        {
            get
            {
                return huidigeBelading;
            }
            private set
            {

                if (value > maximumLaadgewicht)
                {
                    Console.WriteLine("get of some lode ");
                }
                huidigeBelading = value;
            }
        }

        public Aanhangwagen(int maximumgewicht,int aantalBanden, int gewicht, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            this.MaximumLaadgewicht = maximumgewicht;
            this.AantalBanden = aantalBanden;
            this.Gewicht = gewicht;
        }

        public void Laden(int gewicht)
        {
            throw new NotImplementedException();
        }

        public void Lossen(int gewicht)
        {
            throw new NotImplementedException();
        }
    }
}

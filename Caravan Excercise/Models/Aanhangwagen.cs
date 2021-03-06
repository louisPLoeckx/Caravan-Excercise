﻿using Caravan_Excercise.Interfaces;
using System;

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
            Gewicht += gewicht;
        }

        public void Lossen(int gewicht)
        {
            Gewicht -= gewicht;

        }

        public override string ToString()
        {
            return base.ToString() + $" Maximum laadgewicht: {maximumLaadgewicht} aantal banden: {aantalBanden} het gewicht: {gewicht}";
        }
    }
}

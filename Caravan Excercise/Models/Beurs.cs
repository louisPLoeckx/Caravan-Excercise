using Caravan_Excercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Models
{
    public class Beurs : IEigendom
    {
        //List<IEigendom> artikels = new List<IEigendom>();

        //Eigendom[] artikels;
        IEigendom[] artikels = new IEigendom[0];
        int number = 0;
        string eigenaar;
        double prijs;

        public string Eigenaar 
        {
            get { return eigenaar; }
            private set { eigenaar = value; }
        }

        public double Prijs 
        {
            get { return prijs; }
            private set { prijs = value;  }
        }
        public Beurs(string eigenaar, double prijs)
        {
            Prijs = prijs;
            Eigenaar = eigenaar;
        }
        public void Add(IEigendom eigendom)
        {
            artikels[number] = eigendom;
            number++;
            Array.Resize(ref artikels, number);
        }

        public void BepaalPrijs(double nieuwePrijs)
        {
            Prijs = nieuwePrijs;
        }

        public void VerkoopAan(string nieuweEigenaar)
        {
            Eigenaar = nieuweEigenaar;
        }
        public IBelaadbaar[] GetBelaadbaarLijst()
        {
            IBelaadbaar[] remork = new IBelaadbaar[0];
            int counter = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBelaadbaar)
                {
                    counter++;
                }
            }
            Array.Resize(ref remork, counter);
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBelaadbaar)
                {
                    remork[i] = (IBelaadbaar)artikels[i];
                }
            }
            return remork;
        }
        public IBewoonbaar[] GetBewoonbaarLijst()
        {
            IBewoonbaar[] woonst = new IBewoonbaar[0];
            int counter = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBewoonbaar)
                {
                    counter++;
                }
            }
            Array.Resize(ref woonst, counter);
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBelaadbaar)
                {
                    woonst[i] = (IBewoonbaar)artikels[i];
                }
            }
            return woonst;
        }
    }
}

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
        public IEigendom[] artikels = new IEigendom[0];
        int number = 0;
        string eigenaar;
        double prijs;
        public int CompareTo(Eigendom eigendom)
        {
            return prijs.CompareTo(eigendom.Prijs);
        }

        public string Eigenaar
        {
            get { return eigenaar; }
            private set { eigenaar = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            private set { prijs = value; }
        }
        public Beurs(string eigenaar, double prijs)
        {
            Prijs = prijs;
            Eigenaar = eigenaar;
        }
        public void Add(IEigendom eigendom)
        {
            number++;
            Array.Resize(ref artikels, number);
            artikels[number - 1] = eigendom;
            Array.Sort(artikels);
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
            int counterTwee = 0;
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
                    remork[counterTwee] = (IBelaadbaar)artikels[i];
                    counterTwee++;
                }
            }
            Console.WriteLine($"Artikels that are loadable: {remork.Length}");
            return remork;
        }
        public IBewoonbaar[] GetBewoonbaarLijst()
        {
            IBewoonbaar[] woonst = new IBewoonbaar[0];
            int counter = 0;
            int counterTwee = 0;
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
                if (artikels[i] is IBewoonbaar)
                {
                    woonst[counterTwee] = (IBewoonbaar)artikels[i];
                    counterTwee++;
                }
            }
            Console.WriteLine($"Artikels that are Livable: {woonst.Length}");
            return woonst;
        }
        public ITrekbaar[] GetTrekbaarLijst()
        {
            ITrekbaar[] pullable = new ITrekbaar[0];
            int counter = 0;
            int counterTwee = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekbaar)
                {
                    counter++;
                }
            }
            Array.Resize(ref pullable, counter);
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekbaar)
                {
                    pullable[counterTwee] = (ITrekbaar)artikels[i];
                    counterTwee++;
                }
            }
            Console.WriteLine($"Artikels that are pullable: {pullable.Length}");
            return pullable;
        }
        public ITrekker[] GetTrekkerLijst()
        {
            ITrekker[] trekker = new ITrekker[0];
            int counter = 0;
            int counterTwee = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekker)
                {
                    counter++;
                }
            }
            Array.Resize(ref trekker, counter);
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekker)
                {
                    trekker[counterTwee] = (ITrekker)artikels[i];
                    counterTwee++;
                }
            }
            Console.WriteLine($"Artikels that are pullers: {trekker.Length}");
            return trekker;
        }
        public IVoertuig[] GetVoertuigLijst()
        {
            //foreach (var item in artikels)
            //{
            //    Console.WriteLine($"{item.ToString()}");
            //}
            //Array.Sort(artikels);
            //foreach (var item in artikels)
            //{
            //    Console.WriteLine($"{item.ToString()}");
            //}
            IVoertuig[] driveable = new IVoertuig[0];
            int counter = 0;
            int counterTwee = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IVoertuig)
                {
                    counter++;
                }
            }
            Array.Resize(ref driveable, counter);
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IVoertuig)
                {
                    driveable[counterTwee] = (IVoertuig)artikels[i];
                    counterTwee++;
                }
            }
            
            Console.WriteLine($"Artikels that are driveable: {driveable.Length}");
            return driveable;
        }

        public int CompareTo(IEigendom eigendom)
        {
            return Prijs.CompareTo(eigendom.Prijs);
        }
    }
}

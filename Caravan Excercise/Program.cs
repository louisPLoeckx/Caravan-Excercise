using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Models;

namespace Caravan_Excercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aanhangwagen KamionTrailer = new Aanhangwagen(1, 2000, "Jef", 9999d);
                Caravan SleurHut = new Caravan(1, 2.2, 4, 22, "Jim", 2000d);
                Kasteel Steen = new Kasteel(5, 20000, "Juan", 9999d);
                Console.WriteLine(Steen.AantalSlaapkamers);
                Transportboot transportboot = new Transportboot(150, "bootmerk", 80, "Jack", 999d, 1000);
                transportboot.Laden(50);
                transportboot.Versnel(50);
                Beurs beurs = new Beurs("Marc", 500000);
                beurs.Add(KamionTrailer);
                beurs.Add(Steen);
                beurs.Add(SleurHut);
                beurs.Add(transportboot);
                beurs.GetBewoonbaarLijst();
                Console.WriteLine("Prijzen:");
                foreach (var item in beurs.artikels)
                {
                    Console.WriteLine(item);
                }
                Array.Sort(beurs.artikels);
                foreach (var item in beurs.artikels)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

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
                Huis Home = new Huis(6, 800, "7th floor gang", 2000000);
                Kasteel Steen = new Kasteel(5, 20000, "Juan", 9999d);
                Auto Jeep = new Auto(140, 25, 1000, "Wrangler", "Yannick", 40000);
                Motorhome RV = new Motorhome(25, 140, 25, 2000, "Mercedes", "Mohammed", 400000);
                Transportboot transportboot = new Transportboot(150, "bootmerk", 80, "Jack", 999d, 1000);
                WoonBoot FloatingHome = new WoonBoot(4, 400, 100, "Dutch Brand", 25, "Dutchy", 400000);
                Beurs beurs = new Beurs("Marc", 500000);

                //Aanhangwagen.Laden(50);
                //transportboot.Versnel(50);
                beurs.Add(KamionTrailer);
                beurs.Add(SleurHut);
                beurs.Add(Home);
                beurs.Add(Steen);
                beurs.Add(Jeep);
                beurs.Add(RV);
                beurs.Add(transportboot);
                beurs.Add(FloatingHome);
                
                beurs.GetBewoonbaarLijst();
                foreach (var item in beurs.artikels)
                {
                    Console.WriteLine($"{item.Eigenaar} {item.Prijs}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

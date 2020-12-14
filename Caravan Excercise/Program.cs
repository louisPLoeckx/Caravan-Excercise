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
                Kasteel Steen = new Kasteel(2, 20000, "Juan", 9999d);
                //Console.WriteLine(Steen.aantalSlaapkamers);
                Transportboot transportboot = new Transportboot(150, "bootmerk", 80, "Jack", 999d, 1000);
                transportboot.Laden(500);
                transportboot.Versnel(500);
                Console.WriteLine(transportboot);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

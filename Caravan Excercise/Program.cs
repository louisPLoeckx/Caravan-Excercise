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
            Aanhangwagen KamionTrailer = new Aanhangwagen(1, 2000);
            Caravan SleurHut = new Caravan(1,2.2,4,22);
            Kasteel Steen = new Kasteel(2, 20000);
            Console.WriteLine(Steen.aantalSlaapkamers);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan_Excercise.Models;

namespace Caravan_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Aanhangwagen KamionTrailer = new Aanhangwagen(1, 2000);
            Caravan SleurHut = new Caravan(1,2.2,4,22);
        }
    }
}

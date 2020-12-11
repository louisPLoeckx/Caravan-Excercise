using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Interfaces
{
    interface IVoertuig
    {
        int MaximumSnelheid { get; }
        string Merk { get; }
        int Snelheid { get; }

        void Versnel(int versnelling);
        void Vertraag(int vertraging);
    }
}

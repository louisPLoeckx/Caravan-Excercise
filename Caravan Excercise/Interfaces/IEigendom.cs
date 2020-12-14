using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Interfaces
{
    public interface IEigendom
    {
        string Eigenaar { get; }
        double Prijs { get; }
        void BepaalPrijs(double nieuwePrijs);
        void VerkoopAan(string nieuweEigenaar);
    }
}

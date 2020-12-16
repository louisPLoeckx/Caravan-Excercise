using System;

namespace Caravan_Excercise.Interfaces
{
    public interface IEigendom: IComparable<IEigendom>
    {
        string Eigenaar { get; }
        double Prijs { get; }
        void BepaalPrijs(double nieuwePrijs);
        void VerkoopAan(string nieuweEigenaar);
    }
}

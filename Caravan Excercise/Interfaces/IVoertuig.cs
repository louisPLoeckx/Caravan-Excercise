﻿

namespace Caravan_Excercise.Interfaces
{
    public interface IVoertuig
    {
        int MaximumSnelheid { get; }
        string Merk { get; }
        int Snelheid { get; }

        void Versnel(int versnelling);
        void Vertraag(int vertraging);
    }
}

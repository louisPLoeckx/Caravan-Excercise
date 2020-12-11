using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan_Excercise.Interfaces
{
    interface ITrekker
    {
        ITrekbaar Aanhangwagen { get; }
        int MaximaalTrekGewicht { get; }

        void KoppelAanhangwagen(ITrekbaar aanhangwagen);
    }
}



namespace Caravan_Excercise.Interfaces
{
    public interface ITrekker
    {
        ITrekbaar Aanhangwagen { get; }
        int MaximaalTrekGewicht { get; }

        void KoppelAanhangwagen(ITrekbaar aanhangwagen);
    }
}

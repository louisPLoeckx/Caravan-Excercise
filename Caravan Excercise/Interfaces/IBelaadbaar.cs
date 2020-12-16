

namespace Caravan_Excercise.Interfaces
{
    public interface IBelaadbaar
    {
        int HuidigeBelading { get; }
        int MaximumLaadgewicht { get; }
        void Laden(int gewicht);
        void Lossen(int gewicht);
    }
}

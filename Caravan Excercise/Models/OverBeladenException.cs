using System;

namespace Caravan_Excercise.Models
{
    public class OverBeladenException : Exception
    {
        public int MaximaleTrekkracht { get; private set; }
        public int TeTrekkenGewicht { get; private set; }

        public OverBeladenException(int maximumrekkracht,int trekkenGewicht,string message)
            :base($" {message} {maximumrekkracht} {trekkenGewicht}")
        {
            MaximaleTrekkracht = maximumrekkracht;
            TeTrekkenGewicht = trekkenGewicht;
        }
    }
}

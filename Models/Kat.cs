using System;
using Asiel;

namespace Models
{
    public class Kat : Dier
    {
        public string Info { get; set; }

        public Kat()
        {
        }

        public void BerekenPrijs()
        {
            if (String.IsNullOrEmpty(Info))
            {
                base.Price = 350;
            }
            else
            {
                foreach (Char c in Info)
                {
                    base.Price = base.Price - 20;
                }

                if (Info.Length > 15)
                {
                    base.Price = 35;
                }
            }
        }
    }
}
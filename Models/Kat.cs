using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel.Dieren
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
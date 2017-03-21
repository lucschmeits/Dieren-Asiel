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

        public Kat(string naam, Geslacht geslacht)
        {
            base.naam = naam;
            base.GeslachtSet = geslacht;
        }

        public void BerekenPrijs()
        {
            base.Price = 350;
            if (String.IsNullOrEmpty(Info))
            {
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
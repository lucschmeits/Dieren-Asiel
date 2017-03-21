using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Asiel.Dieren
{
    public class Hond : Dier
    {
        public DateTime LaatstUitgelaten { get; set; }

        public Hond(string naam, Geslacht geslacht)
        {
            base.naam = naam;
            base.GeslachtSet = geslacht;
        }

        public void BerekenPrijs(List<Dier> dierList)
        {
            foreach (var x in dierList)
            {
                if (x.GetType() == typeof(Hond))
                {
                    base.Price = 500 - (dierList.Count - 1) * 50;

                    if (dierList.Count > 9)
                    {
                        Price = 50;
                    }
                }
            }
        }
    }
}
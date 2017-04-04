using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Asiel.Dieren
{
    public class Hond : Dier
    {
        private static int _i;
        public DateTime LaatstUitgelaten { get; set; }

        public Hond()
        {
        }

        public void BerekenPrijs(List<Dier> dierList)
        {
            _i = dierList.Count - 1;
            foreach (var x in dierList)
            {
                if (x.GetType() == typeof(Hond))
                {
                    base.Price = 500 - _i * 50;

                    if (dierList.Count > 9)
                    {
                        Price = 50;
                    }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
   public class Hond : Dier
    {
        public DateTime LaatstUitgelaten { get; set; }

     

        public Hond(string naam, Geslacht geslacht)
        {
            base.naam = naam;
            base.GeslachtSet = geslacht;
        }
    }
}

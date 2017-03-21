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
    }
}
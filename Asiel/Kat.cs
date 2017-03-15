using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
    public class Kat : Dier
    {
        public string Info { get; set; }

        //public void AddKat(string name, Geslacht geslacht, List<Dier> dierList )
        //{
        //    var k = new Kat
        //    {
        //        naam = name,
        //        GeslachtSet = geslacht
        //    };
        //    dierList.Add(k);
        //}

        public Kat(string naam, Geslacht geslacht)
        {
            base.naam = naam;
            base.GeslachtSet = geslacht;
        }
    }
}

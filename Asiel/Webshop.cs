using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
    public class Webshop : ISellable
    {
        public string Naam { get; set; }
        public decimal Price { get; set; }
        
        public Webshop(string naam, decimal prijs)
        {
            this.Naam = naam;
            this.Price = prijs;
        }
 
    }
}

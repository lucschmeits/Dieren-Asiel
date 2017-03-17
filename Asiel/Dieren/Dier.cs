using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel.Dieren
{
  public abstract class Dier
    {
       
        public enum Geslacht
        {
            Man,
            Vrouw
        }

        public Geslacht GeslachtSet { get; set; }
        private string _naam;

        public string naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        
    }
}

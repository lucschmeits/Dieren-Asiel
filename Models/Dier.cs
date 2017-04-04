using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Asiel
{
    public abstract class Dier : ISellable
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

        public string Naam { get; set; }
        public decimal Price { get; set; }
    }
}
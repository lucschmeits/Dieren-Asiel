using Asiel;

namespace Models
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
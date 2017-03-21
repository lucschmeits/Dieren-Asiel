using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asiel.Dieren;

namespace Asiel
{
    public class DierAsiel
    {
        public List<Dier> DierList { get; } = new List<Dier>();

        public List<Persoon> PersoonList { get; } = new List<Persoon>();

        public List<Reservering> ReserveringsList { get; } = new List<Reservering>();

        // public List<Dier> ReserveringDierlist { get; } = new List<Dier>();

        public List<Webshop> WebshopList { get; } = new List<Webshop>();

        public void AddKat(Kat kat)
        {
            DierList.Add(kat);
        }

        public void AddDog(Hond hond)
        {
            DierList.Add(hond);
        }

        public void AddPersoon(Persoon persoon)
        {
            PersoonList.Add(persoon);
        }

        public void AddReservering(Reservering r)
        {
            ReserveringsList.Add(r);
        }

        public void AddProduct(Webshop product)
        {
            WebshopList.Add(product);
        }

        public void AddDierToReserveringsList()
        {
        }
    }
}
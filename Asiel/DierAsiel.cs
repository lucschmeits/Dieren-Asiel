using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
   public class DierAsiel
    {
      // public List<Dier> DierList { get; private set; }

        public List<Dier> DierList { get; private set; } = new List<Dier>();

        public List<Persoon> PersoonList { get; private set; } = new List<Persoon>();

        public List<Reservering> ReserveringsList { get; private set; } = new List<Reservering>();
        
        public void AddKat(Kat kat)
        {
            DierList.Add(kat);
        }

        public void AddDog(Hond hond)
        {
            DierList.Add(hond);
        }
    }
}

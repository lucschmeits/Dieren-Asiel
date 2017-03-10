using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
   public class Dier
    {
        //public enum DierType
        //{
        //    Hond,
        //    Kat,

        //}
        //public DierType DierSet { get; set; }

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

        //private DateTime _laatstUitgelaten;

        //public DateTime laatstUitgelaten
        //{
        //    get { return _laatstUitgelaten; }
        //    set { _laatstUitgelaten = value; }
        //}

        //private string _extraInfo;

        //public string extraInfo
        //{
        //    get { return _extraInfo; }
        //    set { _extraInfo = value; }
        //}

        //public void AddDier(string naam, Geslacht geslacht, DierType dier, List<Dier> dierList)
        //{
        //    Dier nieuwDier = new Dier();
        //    nieuwDier.naam = naam;
        //    nieuwDier.GeslachtSet = geslacht;
        //    nieuwDier.DierSet = dier;
        //    dierList.Add(nieuwDier);
        //}

        public List<Enum> GeslachtList()
        {
            List<Enum> GeslachtList = new List<Enum>();
            foreach (Enum e in Enum.GetValues(typeof(Geslacht)))
            {
              GeslachtList.Add(e);
            }
            return GeslachtList;
        }

        //public List<Enum> DierList()
        //{
        //    List<Enum> DierList = new List<Enum>();
        //    foreach (Enum e in Enum.GetValues(typeof(DierType)))
        //    {
        //        DierList.Add(e);
        //    }
        //    return DierList;
        //}
        public List<String> DierList()
        {
            List<String> DierList = new List<string>();
            var subclasses =
                from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from type in assembly.GetTypes()
                where type.IsSubclassOf(typeof(Dier))
                select type;
            foreach (var k in subclasses)
            {
                DierList.Add(k.Name);
            }
            return DierList;
        }
    }
}

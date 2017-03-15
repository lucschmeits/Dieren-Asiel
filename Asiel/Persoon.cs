using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
   public class Persoon
    {
        private string _naam;

        public string naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        private string _achternaam;

        public string achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        private string _straatHuisnr;

        public string straatHuisnr
        {
            get { return _straatHuisnr; }
            set { _straatHuisnr = value; }
        }

        private string _postcode;

        public string postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        private string _woonplaats;

        public string woonplaats
        {
            get { return _woonplaats; }
            set { _woonplaats = value; }
        }

        private string _telefoonNr;

        public string telefoonNr
        {
            get { return _telefoonNr; }
            set { _telefoonNr = value; }
        }


        //public void AddPersoon(string naamInput, string achternaamInput, string straatInput, string postcodeInput, string woonplaatsInput, string telefoonNrInput, List<Persoon> persoonList )
        //{
        //    Persoon persoon = new Persoon
        //    {
        //        naam = naamInput,
        //        achternaam = achternaamInput,
        //        straatHuisnr = straatInput,
        //        postcode = postcodeInput,
        //        woonplaats = woonplaatsInput,
        //        telefoonNr = telefoonNrInput

        //    };
        //    persoonList.Add(persoon);
        //}

        public Persoon(string naam, string achternaam, string straat, string postcode, string woonplaats, string telefoon)
        {
            _naam = naam;
            _achternaam = achternaam;
            _straatHuisnr = straat;
            _postcode = postcode;
            _woonplaats = woonplaats;
            _telefoonNr = telefoon;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asiel.Dieren;

namespace Asiel
{
   public class Reservering
    {
        private DateTime _reserveerDateTime;

        public DateTime reserveerDateTime
        {
            get { return _reserveerDateTime; }
            set { _reserveerDateTime = value; }
        }

        private bool _isOpgehaald;

        public bool isOpgehaald
        {
            get { return _isOpgehaald; }
            set { _isOpgehaald = value; }
        }

        private Persoon _persoon;

        public Persoon persoon
        {
            get { return _persoon; }
            set { _persoon = value; }
        }

        private Dier _dier;

        public Dier dier
        {
            get { return _dier; }
            set { _dier = value; }
        }

        public List<Dier> Dierlist { get; private set; }
      

        public Reservering(Persoon p, Dier d , DateTime datum)
        {
            _persoon = p;
            _dier = d;
            _reserveerDateTime = datum;
            
        }
    }
}

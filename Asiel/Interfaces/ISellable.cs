using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
    interface ISellable
    {
         string Naam { get; set; }
         decimal Price { get; set; }
    }
}

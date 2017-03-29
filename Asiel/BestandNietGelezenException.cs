using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel
{
    internal class BestandNietGelezenException : Exception
    {
        public BestandNietGelezenException()
        {
        }

        public BestandNietGelezenException(string message) : base(message)
        {
        }
    }
}
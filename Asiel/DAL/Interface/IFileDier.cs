using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiel.DAL.Interface
{
    public interface IFileDier
    {
        void SaveDierToFile(DierAsiel dierAsiel);

        void GetDierFromFile(DierAsiel dierAsiel);
    }
}
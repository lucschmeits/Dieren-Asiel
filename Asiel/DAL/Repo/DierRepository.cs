using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asiel.DAL.Interface;

namespace Asiel.DAL.Repo
{
    public class DierRepository
    {
        private IFileDier _fileDierInterface;

        public DierRepository(IFileDier fileDierRepo)
        {
            this._fileDierInterface = fileDierRepo;
        }

        public void GetDierFromFile(DierAsiel dierAsiel)
        {
            _fileDierInterface.GetDierFromFile(dierAsiel);
        }

        public void SaveDierToFile(DierAsiel dierAsiel)
        {
            _fileDierInterface.SaveDierToFile(dierAsiel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using Asiel.DAL.Interface;
using Asiel.Dieren;

namespace Asiel.DAL.Context
{
    public class DierFileContext : IFileDier
    {
        public void GetDierFromFile(DierAsiel dierAsiel)
        {
            string path = @"C:\test\dierlist.xml";
            try
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Dier>), new Type[] { typeof(Hond), typeof(Kat) });
                StreamReader srdr = new StreamReader(path);
                dierAsiel.DierList = (List<Dier>)xmlser.Deserialize(srdr);
                srdr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Het bestand " + path + " bestaat nog niet");
            }
        }

        public void SaveDierToFile(DierAsiel dierAsiel)
        {
            string path = @"C:\test\dierlist.xml";
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Dier>), new Type[] { typeof(Hond), typeof(Kat) });
            StreamWriter swtr = new StreamWriter(path);
            xmlser.Serialize(swtr, dierAsiel.DierList);
            swtr.Close();
        }
    }
}
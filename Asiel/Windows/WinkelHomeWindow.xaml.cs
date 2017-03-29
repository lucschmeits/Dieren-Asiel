using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Asiel.Windows
{
    /// <summary>
    /// Interaction logic for WinkelHomeWindow.xaml
    /// </summary>
    public partial class WinkelHomeWindow : Window
    {
        private DierAsiel _dierAsiel;

        public WinkelHomeWindow(DierAsiel dierAsiel)
        {
            InitializeComponent();
            _dierAsiel = dierAsiel;
            AddProduct();
            ReadWebshopProduct();
        }

        private void BtnNieuwProduct_Click(object sender, RoutedEventArgs e)
        {
            var winkelNieuwProduct = new WinkelNieuwProductWindow(_dierAsiel, ListViewProducten);
            winkelNieuwProduct.Show();
        }

        private void AddProduct()
        {
            ListViewProducten.Items.Clear();
            foreach (var p in _dierAsiel.WebshopList)
            {
                ListViewProducten.Items.Add(p);
            }
        }

        private void BtnVerkoop_Click(object sender, RoutedEventArgs e)
        {
            var product = (Webshop)ListViewProducten.SelectedItem;
            _dierAsiel.WebshopList.Remove(product);
            AddProduct();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            string path = @"C:\test\webshop.txt";
            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var x in _dierAsiel.WebshopList)
                {
                    sw.WriteLine(x.Naam + ";" + x.Price);
                }
                _dierAsiel.WebshopList.Clear();
            }
        }

        private void ReadWebshopProduct()
        {
            string path = @"C:\test\webshop.txt";
            string line;

            try
            {
                if (File.Exists(path))
                {
                    StreamReader file = new StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] x = line.Split(';');

                        for (int i = 0; i < x.Length; i = i + 2)
                        {
                            var p = new Webshop(x[i], Convert.ToDecimal(x[i + 1]));
                            _dierAsiel.WebshopList.Add(p);
                        }
                        AddProduct();
                    }
                    file.Close();
                }
                else
                {
                    throw new BestandNietGelezenException("Het bestand om de producten uit te lezen is niet gevonden");
                }
            }
            catch (BestandNietGelezenException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
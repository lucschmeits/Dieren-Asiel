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
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var x in _dierAsiel.WebshopList)
                {
                    sw.WriteLine(x.Naam + ";" + x.Price);
                }
            }
        }
    }
}
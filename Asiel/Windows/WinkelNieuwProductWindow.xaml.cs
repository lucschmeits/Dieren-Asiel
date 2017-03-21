using System;
using System.Collections.Generic;
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
    /// Interaction logic for WinkelNieuwProductWindow.xaml
    /// </summary>
    public partial class WinkelNieuwProductWindow : Window
    {
        private DierAsiel _dierAsiel;
        private ListView _listViewProducten;

        public WinkelNieuwProductWindow(DierAsiel dierAsiel, ListView listViewProducten)
        {
            InitializeComponent();
            _dierAsiel = dierAsiel;
            _listViewProducten = listViewProducten;
        }

        private void BtnProductToevoegen_Click(object sender, RoutedEventArgs e)
        {
            var x = TbPrijs.Text;
            var replace = x.Replace('.', ',');
            var d = decimal.Parse(replace);
            var product = new Webshop(TbNaam.Text, d);

            _dierAsiel.AddProduct(product);
            _listViewProducten.Items.Clear();
            foreach (var p in _dierAsiel.WebshopList)
            {
                _listViewProducten.Items.Add(p);
            }
            this.Close();
        }
    }
}
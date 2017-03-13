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

namespace Asiel
{
    /// <summary>
    /// Interaction logic for DierInfoWindow.xaml
    /// </summary>
    public partial class DierInfoWindow : Window
    {
        private Dier _dier;
        private List<Dier> _dierList;
        private ListView _listViewDieren;
        public DierInfoWindow(Dier dier, List<Dier> dierList, ListView listViewDieren)
        {
            InitializeComponent();
            _dier = dier;
            _dierList = dierList;
            _listViewDieren = listViewDieren;
            VulVelden();
        }

        private void VulVelden()
        {
            TxtNaam.Text = _dier.naam;
            TxtGeslacht.Text = _dier.GeslachtSet.ToString();
            TxtDierType.Text = _dier.GetType().Name;
            if (_dier.GetType() == typeof(Hond))
            {
                var h = (Hond)_dier;
                TxtInfo.Visibility = Visibility.Hidden;
                if (h.LaatstUitgelaten == default(DateTime))
                {

                }
                else
                {
                    DateUitgelaten.Text = h.LaatstUitgelaten.ToShortDateString();
                }
            }
            if (_dier.GetType() == typeof(Kat))
            {
                var k = (Kat)_dier;
                DateUitgelaten.Visibility = Visibility.Hidden;
                TxtInfo.Text = k.Info;
            }
        }

        private void BtnBijwerken_Click(object sender, RoutedEventArgs e)
        {
            if (_dier.GetType() == typeof(Hond))
            {
                var h = (Hond)_dier;
                
                h.naam = TxtNaam.Text;
                h.LaatstUitgelaten = (DateTime)DateUitgelaten.SelectedDate;
            }
            if (_dier.GetType() == typeof(Kat))
            {
                var k = (Kat)_dier;
                k.Info = TxtInfo.Text;
            }
            _listViewDieren.Items.Clear();
            VulView();
            this.Close();

        }

        private void VulView()
        {
            foreach (var d in _dierList)
            {
                _listViewDieren.Items.Add(d);
            }
        }
    }
}



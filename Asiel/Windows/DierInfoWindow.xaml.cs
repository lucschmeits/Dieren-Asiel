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
using Models;

namespace Asiel
{
    /// <summary>
    /// Interaction logic for DierInfoWindow.xaml
    /// </summary>
    public partial class DierInfoWindow : Window
    {
        private readonly Dier _dier;

        private readonly ListView _listViewDieren;
        private readonly DierAsiel _dierAsiel;

        public DierInfoWindow(Dier dier, DierAsiel asiel, ListView listViewDieren)
        {
            InitializeComponent();
            _dier = dier;

            _dierAsiel = asiel;
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
                k.BerekenPrijs();
                DateUitgelaten.Visibility = Visibility.Hidden;
                TxtInfo.Text = k.Info;
            }
            TbPrijs.Text = _dier.Price.ToString();
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
            foreach (var d in _dierAsiel.DierList)
            {
                _listViewDieren.Items.Add(d);
            }
        }
    }
}
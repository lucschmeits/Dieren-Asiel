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
        public DierInfoWindow(Dier dier, List<Dier> dierList, ListView listViewDieren )
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
            TxtDierType.Text = _dier.DierSet.ToString();
            if (_dier.DierSet == Dier.DierType.Hond)
            {
                TxtInfo.Visibility = Visibility.Hidden;
                if (_dier.laatstUitgelaten == default(DateTime))
                {

                }
                else
                {
                    DateUitgelaten.Text = _dier.laatstUitgelaten.ToShortDateString();
                }

            }
            if (_dier.DierSet == Dier.DierType.Kat)
            {
                DateUitgelaten.Visibility = Visibility.Hidden;
                TxtInfo.Text = _dier.extraInfo;
            }
           
            
        }

        private void BtnBijwerken_Click(object sender, RoutedEventArgs e)
        {
            _dier.naam = TxtNaam.Text;
            if (_dier.DierSet == Dier.DierType.Hond)
            {
                _dier.laatstUitgelaten = (DateTime)DateUitgelaten.SelectedDate;
            }
            if (_dier.DierSet == Dier.DierType.Kat)
            {
                _dier.extraInfo = TxtInfo.Text;
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

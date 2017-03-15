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
    /// Interaction logic for PersoonInfoWindow.xaml
    /// </summary>
    public partial class PersoonInfoWindow : Window
    {
        private readonly Persoon _p;
        private readonly ListView _listViewPersoon;
      //  private List<Persoon> _persoonList;
        private readonly DierAsiel _asiel;
        public PersoonInfoWindow(Persoon p, ListView listViewPersoon, DierAsiel asiel )
        {
            InitializeComponent();
            _p = p;
            _listViewPersoon = listViewPersoon;
           // _persoonList = persoonList;
            _asiel = asiel;
            VulVelden();
        }

        private void VulVelden()
        {
            TxtNaam.Text = _p.naam;
            TxtAchternaam.Text = _p.achternaam;
            TxtStraatHuisNr.Text = _p.straatHuisnr;
            TxtPostcode.Text = _p.postcode;
            TxtWoonplaats.Text = _p.woonplaats;
            TxtTelefoon.Text = _p.telefoonNr;
        }

        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            _p.naam = TxtNaam.Text;
            _p.achternaam = TxtAchternaam.Text;
            _p.straatHuisnr = TxtStraatHuisNr.Text;
            _p.postcode = TxtPostcode.Text;
            _p.woonplaats = TxtWoonplaats.Text;
            _p.telefoonNr = TxtTelefoon.Text;
            _listViewPersoon.Items.Clear();
            VulView();
            this.Close();
        }

        private void VulView()
        {
            foreach (var p in _asiel.PersoonList)
            {
                _listViewPersoon.Items.Add(p);
            }
        }
    }
}

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
        private Persoon _p;
        public PersoonInfoWindow(Persoon p)
        {
            InitializeComponent();
            _p = p;
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
    }
}

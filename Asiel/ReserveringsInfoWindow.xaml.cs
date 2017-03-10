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
    /// Interaction logic for ReserveringsInfoWindow.xaml
    /// </summary>
    public partial class ReserveringsInfoWindow : Window
    {
        private Reservering _reservering;
        public ReserveringsInfoWindow(Reservering reservering)
        {
            InitializeComponent();
            _reservering = reservering;
            VulVelden();
        }

        private void VulVelden()
        {
            TxtNaamPersoon.Text = _reservering.persoon.naam;
            TxtAchternaam.Text = _reservering.persoon.achternaam;
            TxtStraat.Text = _reservering.persoon.straatHuisnr;
            TxtPostcode.Text = _reservering.persoon.postcode;
            TxtWoonplaats.Text = _reservering.persoon.woonplaats;
            TxtTelefoon.Text = _reservering.persoon.telefoonNr;

            //TxtDierNaam.Text = _reservering.dier.naam;
            //TxtDierGeslacht.Text = _reservering.dier.GeslachtSet.ToString();
            //TxtDierType.Text = _reservering.dier.DierSet.ToString();
            //TxtUitgelaten.Text = _reservering.dier.laatstUitgelaten.ToShortDateString();
            //TxtInfo.Text = _reservering.dier.extraInfo;
        }
    }
}

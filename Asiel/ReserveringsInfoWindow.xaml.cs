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
using Asiel.Dieren;

namespace Asiel
{
    /// <summary>
    /// Interaction logic for ReserveringsInfoWindow.xaml
    /// </summary>
    public partial class ReserveringsInfoWindow : Window
    {
        private readonly Reservering _reservering;
        public ReserveringsInfoWindow(Reservering reservering)
        {
            InitializeComponent();
            _reservering = reservering;
            VulVelden();
            VulComboBox();
        }

        private void VulVelden()
        {
            TxtNaamPersoon.Text = _reservering.persoon.naam;
            TxtAchternaam.Text = _reservering.persoon.achternaam;
            TxtStraat.Text = _reservering.persoon.straatHuisnr;
            TxtPostcode.Text = _reservering.persoon.postcode;
            TxtWoonplaats.Text = _reservering.persoon.woonplaats;
            TxtTelefoon.Text = _reservering.persoon.telefoonNr;

            TxtDierNaam.Text = _reservering.dier.naam;
            TxtDierGeslacht.Text = _reservering.dier.GeslachtSet.ToString();
            TxtDierType.Text = _reservering.dier.GetType().Name;
            if (_reservering.dier.GetType() == typeof(Hond))
            {
                var h = (Hond) _reservering.dier;
                TxtUitgelaten.Text = h.LaatstUitgelaten.ToShortDateString();
            }
            if (_reservering.dier.GetType() == typeof(Kat))
            {
                var k = (Kat) _reservering.dier;
                TxtInfo.Text = k.Info;
            }
            
        }

        private void VulComboBox()
        {
            cmbOpgehaald.Items.Add("Opgehaald");
            cmbOpgehaald.Items.Add("Niet opgehaald");
            cmbOpgehaald.Text = _reservering.isOpgehaald ? "Opgehaald" : "Niet opgehaald";
           
        }

        private void BtnAanpassen_Click(object sender, RoutedEventArgs e)
        {
            if (cmbOpgehaald.SelectedItem.ToString() == "Opgehaald")
            {
                _reservering.isOpgehaald = true;
                
            }
            else
            {
                _reservering.isOpgehaald = false;
            }
            this.Close();
        }
    }
}

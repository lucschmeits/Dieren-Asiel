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
    /// Interaction logic for NieuwPersoonWindow.xaml
    /// </summary>
    public partial class NieuwPersoonWindow : Window
    {
        private readonly ListView _listViewPersonen;
        private readonly DierAsiel _dierAsiel;

        public NieuwPersoonWindow(DierAsiel dierAsiel, ListView listViewPersonen)
        {
            InitializeComponent();

            _dierAsiel = dierAsiel;
            _listViewPersonen = listViewPersonen;
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            var p = new Persoon(TxtNaam.Text, TxtAchternaam.Text, TxtStraatHuisNr.Text, TxtPostcode.Text, TxtWoonplaats.Text, TxtTelefoon.Text);
            _dierAsiel.AddPersoon(p);

            _listViewPersonen.Items.Clear();

            VulView();
            this.Close();
        }

        private void VulView()
        {
            foreach (var p in _dierAsiel.PersoonList)
            {
                _listViewPersonen.Items.Add(p);
            }
        }
    }
}
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
    /// Interaction logic for NieuwPersoonWindow.xaml
    /// </summary>
    public partial class NieuwPersoonWindow : Window
    {
        private List<Persoon> _persoonList;
        private ListView _listViewPersonen;
        public NieuwPersoonWindow(List<Persoon> persoonList, ListView listViewPersonen)
        {
            InitializeComponent();
            _persoonList = persoonList;
            _listViewPersonen = listViewPersonen;
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Persoon p = new Persoon();
            p.AddPersoon(TxtNaam.Text, TxtAchternaam.Text, TxtStraatHuisNr.Text, TxtPostcode.Text, TxtWoonplaats.Text, TxtTelefoon.Text);
            _listViewPersonen.Items.Clear();
            _persoonList.Add(p);
            VulView();
        }

        private void VulView()
        {
            foreach (var p in _persoonList)
            {
                _listViewPersonen.Items.Add(p);
            }
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Asiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Dier> DierenList { get; set; } = new List<Dier>();

        public List<Reservering> ReserveringsList { get; set; } = new List<Reservering>();

        public List<Persoon> PersoonList { get; set; } = new List<Persoon>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNieuwDier_Click(object sender, RoutedEventArgs e)
        {
            var niewDier = new NieuwDierWindow(ListviewDier, DierenList);
            niewDier.Show();
        }

        private void VulView()
        {
           foreach (var r in ReserveringsList)
            {
                ListviewReservering.Items.Add(r);
            }
        }

        private void ListviewDier_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var d = (Dier) ListviewDier.SelectedItem;
            var info = new DierInfoWindow(d);
            info.Show();
        }

        private void btnNieuwPersoon_Click(object sender, RoutedEventArgs e)
        {
            NieuwPersoonWindow nieuwPersoonWindow = new NieuwPersoonWindow(PersoonList, ListviewPersoon);
            nieuwPersoonWindow.Show();
        }

        private void ListviewPersoon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var d = (Persoon) ListviewPersoon.SelectedItem;

        }
    }
}

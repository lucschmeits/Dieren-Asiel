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
            var info = new DierInfoWindow(d, DierenList, ListviewDier);
            info.Show();
        }

        private void btnNieuwPersoon_Click(object sender, RoutedEventArgs e)
        {
            var nieuwPersoonWindow = new NieuwPersoonWindow(PersoonList, ListviewPersoon);
            nieuwPersoonWindow.Show();
        }

        private void ListviewPersoon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var p = (Persoon) ListviewPersoon.SelectedItem;
            var info = new PersoonInfoWindow(p, ListviewPersoon, PersoonList);
            info.Show();
        }

        private void BtnReserveer_Click(object sender, RoutedEventArgs e)
        {
            var d = (Dier) ListviewDier.SelectedItem;
            var p = (Persoon) ListviewPersoon.SelectedItem;
            var reservering = new Reservering();
            try
            {
                if (p == null || d == null || DatePickerReservering.DisplayDate == default(DateTime))
                {
                    MessageBox.Show("Er moet een dier, persoon en een datum geselecteerd zijn");
                }
                else
                {
                    reservering.ReserveerDier(p, d, DatePickerReservering.SelectedDate.Value, ReserveringsList);
                }
               
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Er moet een dier, persoon en een datum geselecteerd zijn");
            }
          
            
            ListviewReservering.Items.Clear();
            VulView();
        }

        private void ListviewReservering_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var r = (Reservering) ListviewReservering.SelectedItem;
            var reserveringsInfo = new ReserveringsInfoWindow(r);
            reserveringsInfo.Show();
        }
    }
}

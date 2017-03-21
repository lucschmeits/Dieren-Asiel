using System;
using System.Windows;
using System.Windows.Input;
using Asiel.Dieren;
namespace Asiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DierAsiel _dierAsiel = new DierAsiel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNieuwDier_Click(object sender, RoutedEventArgs e)
        {
            var niewDier = new NieuwDierWindow(ListviewDier, _dierAsiel);
            niewDier.Show();
        }

        private void VulView()
        {
           foreach (var r in _dierAsiel.ReserveringsList)
            {
                ListviewReservering.Items.Add(r);
            }
        }

        private void ListviewDier_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var dier = (Dier) ListviewDier.SelectedItem;
                var info = new DierInfoWindow(dier, _dierAsiel, ListviewDier);
                info.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Er is geen dier geselecteerd.");
            }
          
        }

        private void btnNieuwPersoon_Click(object sender, RoutedEventArgs e)
        {
            var nieuwPersoonWindow = new NieuwPersoonWindow(_dierAsiel, ListviewPersoon);
            nieuwPersoonWindow.Show();
        }

        private void ListviewPersoon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var p = (Persoon) ListviewPersoon.SelectedItem;
                var info = new PersoonInfoWindow(p, ListviewPersoon, _dierAsiel);
                info.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Er is geen persoon geselecteerd.");
            }
         
          
        }

        private void BtnReserveer_Click(object sender, RoutedEventArgs e)
        {
            
            var d =  (Dier)ListviewDier.SelectedItem;
            var p = (Persoon) ListviewPersoon.SelectedItem;
            //foreach (var s in ListviewDier.SelectedItems)
            //{
            //    _dierAsiel.ReserveringDierlist.Add((Dier)s);
            //}
            try
            {
                if (p == null || d == null || DatePickerReservering.DisplayDate == default(DateTime))
                {
                    MessageBox.Show("Er moet een dier, persoon en een datum geselecteerd zijn");
                }
                else
                {
                    var r = new Reservering(p, d, DatePickerReservering.SelectedDate.Value);
                    _dierAsiel.AddReservering(r);
                  
                }
               
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Er moet een dier, persoon en een datum geselecteerd zijn.");
            }
          
            
            ListviewReservering.Items.Clear();
            VulView();
        }

        private void ListviewReservering_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var r = (Reservering) ListviewReservering.SelectedItem;
                var reserveringsInfo = new ReserveringsInfoWindow(r, _dierAsiel, ListviewReservering);
                reserveringsInfo.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Er moet een reservering geselecteerd zijn.");
            }
          
        }

        private void BtnWinkel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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

        public MainWindow()
        {
            InitializeComponent();
            VulView();
        }

        private void btnNieuwDier_Click(object sender, RoutedEventArgs e)
        {
            NieuwDierWindow niewDier = new NieuwDierWindow(ListviewDier, DierenList);
            niewDier.Show();
        }

        private void VulView()
        {
            foreach (Dier d in DierenList)
            {
                ListviewDier.Items.Add(d);
            }

            foreach (Reservering r in ReserveringsList)
            {
                ListviewReservering.Items.Add(r);
            }
        }

       
    }
}

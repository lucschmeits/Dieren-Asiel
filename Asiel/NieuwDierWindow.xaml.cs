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
    /// Interaction logic for NieuwDierWindow.xaml
    /// </summary>
    public partial class NieuwDierWindow : Window
    {
        private ListView _listViewDieren;
        private List<Dier> _dierList;

        public NieuwDierWindow(ListView listViewDieren, List<Dier> dierList)
        {
            InitializeComponent();
            VulComboBox();
            _listViewDieren = listViewDieren;
            _dierList = dierList;
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Dier.Geslacht selectedGeslacht = (Dier.Geslacht) CmbGeslacht.SelectedItem;
            Dier.DierType selectedDier = (Dier.DierType) CmbDierType.SelectedItem;
            Dier dier = new Dier();
            dier.AddDier(TxtNaamDier.Text, selectedGeslacht, selectedDier, _dierList);
            _listViewDieren.Items.Clear();
            VulView();
        }

        private void VulComboBox()
        {
            Dier d = new Dier();
            CmbDierType.ItemsSource = d.DierList();
            CmbGeslacht.ItemsSource = d.GeslachtList();
        }

        private void VulView()
        {
            foreach (Dier d in _dierList)
            {
                _listViewDieren.Items.Add(d);
            }
        }
    }
}

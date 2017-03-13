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
            if ((String)CmbDierType.SelectedItem == "Hond")
            {
                var h = new Hond();
                Dier.Geslacht geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                h.AddHond(TxtNaamDier.Text, geslacht, _dierList);
                _listViewDieren.Items.Clear();
                VulView();
                this.Close();

            }
            if ((String)CmbDierType.SelectedItem == "Kat")
            {
                var k = new Kat();
                Dier.Geslacht geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                k.AddKat(TxtNaamDier.Text, geslacht, _dierList);
                _listViewDieren.Items.Clear();
                VulView();
                this.Close();
            }
        }

        private void VulComboBox()
        {
            CmbDierType.ItemsSource = DierList();
            CmbGeslacht.ItemsSource = GeslachtList();
        }
        private List<Enum> GeslachtList()
        {
            List<Enum> GeslachtList = new List<Enum>();
            foreach (Enum e in Enum.GetValues(typeof(Dier.Geslacht)))
            {
                GeslachtList.Add(e);
            }
            return GeslachtList;
        }

        private List<string> DierList()
        {
            var dierList = new List<string>();
            var subclasses =
                from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from type in assembly.GetTypes()
                where type.IsSubclassOf(typeof(Dier))
                select type;
            foreach (var k in subclasses)
            {
                dierList.Add(k.Name);
            }
            return dierList;
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

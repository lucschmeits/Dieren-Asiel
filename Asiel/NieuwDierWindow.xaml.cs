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
        private readonly ListView _listViewDieren;
      
        private readonly DierAsiel _dierAsiel;

        public NieuwDierWindow(ListView listViewDieren, DierAsiel dierAsiel)
        {
            InitializeComponent();
            VulComboBox();
            _listViewDieren = listViewDieren;
          
            _dierAsiel = dierAsiel;
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            if ((String)CmbDierType.SelectedItem == "Hond")
            {
                
                Dier.Geslacht geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                var h = new Hond(TxtNaamDier.Text, geslacht);
                _dierAsiel.AddDog(h);
                _listViewDieren.Items.Clear();
                VulView();
                this.Close();

            }
            if ((String)CmbDierType.SelectedItem == "Kat")
            {
                Dier.Geslacht geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                var k = new Kat(TxtNaamDier.Text, geslacht);
                _dierAsiel.AddKat(k);
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
            foreach (Dier d in _dierAsiel.DierList)
            {
                _listViewDieren.Items.Add(d);
            }
        }
    }
}

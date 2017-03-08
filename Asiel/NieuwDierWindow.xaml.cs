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
        public NieuwDierWindow(ListView listViewDieren, List<Dier> dierList )
        {
            InitializeComponent();
            _listViewDieren = listViewDieren;
            _dierList = dierList;
        }
    }
}

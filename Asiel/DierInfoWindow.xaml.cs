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
    /// Interaction logic for DierInfoWindow.xaml
    /// </summary>
    public partial class DierInfoWindow : Window
    {
        private Dier _dier;
        public DierInfoWindow(Dier dier)
        {
            InitializeComponent();
            _dier = dier;
            VulVelden();
        }

        private void VulVelden()
        {
            TxtNaam.Text = _dier.naam;
            TxtGeslacht.Text = _dier.GeslachtSet.ToString();
            TxtDierType.Text = _dier.DierSet.ToString();
            TxtInfo.Text = _dier.extraInfo;
        }
    }
}

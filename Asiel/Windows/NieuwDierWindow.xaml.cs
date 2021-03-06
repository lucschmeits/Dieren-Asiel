﻿using System;
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
using Models;

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
            if ((string)CmbDierType.SelectedItem == "Hond")
            {
                var geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                var h = new Hond();
                h.naam = TxtNaamDier.Text;
                h.GeslachtSet = geslacht;
                _dierAsiel.AddDog(h);
                _listViewDieren.Items.Clear();
                VulView();
                h.BerekenPrijs(_dierAsiel.DierList);
                this.Close();
            }
            if ((string)CmbDierType.SelectedItem == "Kat")
            {
                var geslacht = (Dier.Geslacht)CmbGeslacht.SelectedItem;
                var k = new Kat();
                k.naam = TxtNaamDier.Text;
                k.GeslachtSet = geslacht;
                _dierAsiel.AddKat(k);

                _listViewDieren.Items.Clear();
                VulView();
                // k.BerekenPrijs();
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
            foreach (var d in _dierAsiel.DierList)
            {
                _listViewDieren.Items.Add(d);
            }
        }
    }
}
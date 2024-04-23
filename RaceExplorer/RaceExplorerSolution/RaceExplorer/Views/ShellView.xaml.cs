using RaceExplorer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using RaceExplorer.ViewModels;

namespace RaceExplorer.Views
{
    /// <summary>
    /// Logika interakcji dla klasy ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {



        private string _totalRaceObstacles = "TOTAL";
        public string TotalRaceObstacles
        {
            //get { return raceData.TotalObstacles.ToString();}
            get { return _totalRaceObstacles; }
        }

        private string _selectedProfile;

        public string SelectedProfile
        {
            get { return _selectedProfile; }
            set { _selectedProfile = value; }
        }

        private string _selectedRaceFolder;

        public string SelectedRaceFolder
        {
            get { return _selectedRaceFolder; }
            set { _selectedRaceFolder = value; }
        }



        public ShellView()
        {
            InitializeComponent();
        }

        private void RaceListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            ListBoxItem lbi = lb.SelectedItem as ListBoxItem;
            TextBlock tb = (TextBlock)lbi.Content;
            SelectedRaceFolder = tb.Text;

            
            _ = SelectedRaceFolder == null ? ExplorerPath.profileChildName = "" : ExplorerPath.profileChildName = SelectedRaceFolder;
            ExplorerPath.updatePath();
        }

        private void ProfileListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            //ListBoxItem lbi = lb.SelectedItem as ListBoxItem;
            //TextBlock tb = (TextBlock)lbi.Content;
            SelectedProfile = lb.SelectedItem.ToString();


            _ = SelectedProfile == null ? ExplorerPath.profileName = "" : ExplorerPath.profileName = SelectedProfile;
            ExplorerPath.updatePath();
        }

    }
}

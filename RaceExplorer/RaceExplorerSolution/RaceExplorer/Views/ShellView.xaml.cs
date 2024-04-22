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





        public ShellView()
        {
            InitializeComponent();

        }
    }
}

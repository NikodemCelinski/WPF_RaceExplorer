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
        string testChartPath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\Charts\level2PitStops2024-04-19-00-02\ChartDataList.txt";
        //RaceData raceData = new RaceData();
        //ObservableCollection<ChartDataPoint> raceChartData = new ObservableCollection<ChartDataPoint>();

        private RaceData raceData = new RaceData();

        public RaceData PropRaceData
        {
            get { return raceData = new RaceData(); }
            set { raceData = value; }
        }

        private ObservableCollection<ChartDataPoint> _chartCollection;

        public ObservableCollection<ChartDataPoint> ChartCollection
        {
            get { return _chartCollection; }
            set { _chartCollection = value; }
        }



        public ShellView()
        {
            InitializeComponent();
            raceData.getDataFrom(testChartPath);
            _chartCollection = raceData.Chart;
        }
    }
}

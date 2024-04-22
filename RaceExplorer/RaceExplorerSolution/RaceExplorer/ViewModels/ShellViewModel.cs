using Caliburn.Micro;
using RaceExplorer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;

namespace RaceExplorer.ViewModels
{
    public class ShellViewModel: Conductor<object>
    {
       
		private int _firstName;

		public int FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

        private int _profileListData;

        public int ProfileListItem
        {
            get { return _profileListData; }
            set { _profileListData = value; }
        }

        private List<string> _profileList = new List<string>();

        public List<string> ProfileList
        {
            get { return _profileList; }
            
        }

        string testChartPath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\Charts\level2PitStops2024-04-19-00-02\ChartDataList.txt";
        //RaceData raceData = new RaceData();
        //ObservableCollection<ChartDataPoint> raceChartData = new ObservableCollection<ChartDataPoint>();


        private RaceData raceData = new RaceData();

        public RaceData PropRaceData
        {
            get { return raceData = new RaceData(); }
            set { raceData = value; }
        }

        private ObservableCollection<ChartDataPoint> _chartCollection = new ObservableCollection<ChartDataPoint>();

        public ObservableCollection<ChartDataPoint> ChartCollection
        {
            get { return _chartCollection; }
            set { _chartCollection = value; }
        }


        public ShellViewModel()
        {
            _profileList = getProfileNames();
            raceData.getDataFrom(testChartPath);
            _chartCollection = raceData.Chart;
        }


        public List<string> getProfileNames()
        {
            string profilePath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\dummyProfiles";
            List<string> profileList = new List<string>();



            DirectoryInfo directoryInfo = new DirectoryInfo(profilePath);
            FileInfo[] profileFiles = directoryInfo.GetFiles();
            profileList.Clear();
            foreach (FileInfo fileInfo in profileFiles)
            {
                if (fileInfo.Extension == ".profile")
                {
                    profileList.Add(fileInfo.Name.Split(".")[0]);
                }
            }

            return profileList;

        }

        public void LoadStatView()
        {
            //base.ActivateItem(new StatViewModel());
            ActivateItemAsync(new StatViewModel());
        }


    }
}

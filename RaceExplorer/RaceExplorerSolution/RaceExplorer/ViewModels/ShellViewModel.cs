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

        private ObservableCollection<string> _profileList = new ObservableCollection<string>();

        public ObservableCollection<string> ProfileList
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

        private ObservableCollection<string> _racesCollection = new ObservableCollection<string>();

        public ObservableCollection<string> RacesCollection
        {
            get { return _racesCollection; }
            set { _racesCollection = value; }
        }

        //private string _selectedProfile;

        //public string SelectedProfile
        //{
        //    get { return _selectedProfile; }
        //    set { _selectedProfile = value; }
        //}

        //private string _selectedRaceFolder;

        //public string SelectedRaceFolder
        //{
        //    get { return _selectedRaceFolder; }
        //    set { _selectedRaceFolder = value; }
        //}


        public ShellViewModel()
        {
            _profileList = getProfileNames();
            raceData.getDataFrom(testChartPath);
            _racesCollection = getRaceDirsInProfile();
        }

        

        public ObservableCollection<string> getProfileNames()
        {
            string profilePath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\dummyProfiles";
            ObservableCollection<string> profileList = new ObservableCollection<string>();



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

        public ObservableCollection<string> getRaceDirsInProfile()
        {
            if (ExplorerPath.profileName == "")
                return null;

            ExplorerPath.updatePath();

            string profilePath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\dummyProfiles";
            ObservableCollection<string> dirList = new ObservableCollection<string>();



            DirectoryInfo directoryInfo = new DirectoryInfo(ExplorerPath.profilePath);
            DirectoryInfo[] raceFiles = directoryInfo.GetDirectories();
            dirList.Clear();
            foreach (DirectoryInfo dirInfo in raceFiles)
            {
                dirList.Add(dirInfo.Name.Split(".")[1]);
            }

            return dirList;
        }

        

        public void LoadStatView()
        {
            //base.ActivateItem(new StatViewModel());
            ActivateItemAsync(new StatViewModel());
        }


    }
}

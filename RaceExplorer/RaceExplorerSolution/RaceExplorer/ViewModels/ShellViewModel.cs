using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RaceExplorer.ViewModels
{
    public class ShellViewModel: Screen
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
        public ShellViewModel()
        {
            _profileList = getProfileNames();
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


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceExplorer.Models
{
    public class ExplorerPath
    {
        public static string path = "";
        public static string profilePath = "";
        public static string profileName = "";
        public static string profileChildName = "";
        public static string fileName = "ChartDataList.txt";
        public static DateTime raceDateTime;


        public static void updatePath()
        {
            string basePath = @"D:\projekty\mag\WPF_RaceExplorer\WPF_RaceExplorer\RaceExplorer\RaceExplorerSolution\RaceExplorer\DummyData";

            switch ((profileName.Length,profileChildName.Length))
            {
                case (0, 0):
                    path = "";
                    profilePath = "";
                    break;

                case (> 0, 0):
                    path = $"{basePath}\\{profileName}";
                    profilePath= path;
                    break;

                case ( > 0, > 0):
                    path = $"{basePath}\\{profileName}\\{profileChildName}\\";
                    profilePath = $"{basePath}\\{profileName}";
                    break;

                default:
                    break;
            }

            //path = $"{basePath}\\{profileName}\\{profileChildName}\\";
        }

        public static void Clear()
        {
            path= string.Empty ;
            profileChildName= string.Empty ;
            profileName= string.Empty ;
            raceDateTime = DateTime.MinValue ;
        }


    }
}

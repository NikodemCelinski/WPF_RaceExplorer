using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceExplorer.Models
{
    internal class RaceData
    {
        //int _totalObstacles = 12;

        private int _totalObstacles = 12;

        public int TotalObstacles
        {
            get { return _totalObstacles; }
            set { _totalObstacles = value; }
        }


        ObservableCollection<ChartDataPoint> chart = new ObservableCollection<ChartDataPoint>();

        public void getDataFrom(string path)
        {

            //string filePath = Application.dataPath + "/UserStatistics/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt";
            using (StreamReader sw = new StreamReader(path))
            {
                foreach (var element in chart)
                {
                    sw.ReadLine();
                }
            }

            
        }

        public void makeChartImage()
        {
            // manipulacja zmienna chart poprzez biblioteki.
        }
    }
}

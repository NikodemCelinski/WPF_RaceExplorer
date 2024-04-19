using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceExplorer.Models
{
    public class RaceData
    {
        //int _totalObstacles = 12;

        private int _totalObstacles = 12;

        public int TotalObstacles
        {
            get { return _totalObstacles; }
            set { _totalObstacles = value; }
        }


        private ObservableCollection<ChartDataPoint> _chart = new ObservableCollection<ChartDataPoint>();

        public ObservableCollection<ChartDataPoint> Chart
        {
            get { return _chart; }
            set { _chart = value; }  
        }

        public void getDataFrom(string path)
        {

            const Int32 BufferSize = 1024;
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Process line
                    ChartDataPoint chartDataPoint = new ChartDataPoint();
                    chartDataPoint.GetFromString(line);
                    _chart.Add(chartDataPoint);
                }
            }


        }

        public void makeChartImage()
        {
            // manipulacja zmienna chart poprzez biblioteki.
        }
    }
}

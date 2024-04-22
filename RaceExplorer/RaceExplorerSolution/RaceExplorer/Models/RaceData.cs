using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using Caliburn.Micro;
using OxyPlot;
using OxyPlot.Wpf;
using RaceExplorer.ExplorerExceptions;

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

        public float[] Consecutive(int pointCount, float step = 0.15f)
        {
            if (step == 0)
                throw new IllegalArgumentException("step can't be 0 !");


            float[] consecutive = new float[pointCount];
            consecutive[0] = 0;
            for (int i = 0; i < consecutive.Length; i++)
            {
                consecutive[i] = i*step;
            }

            return consecutive;
        }


        public PlotModel MakeDodgeCountChart(List <ChartDataPoint> dataPoints)
        {


            // manipulacja zmienna chart poprzez biblioteki.
            
            float[] xs = Consecutive(Chart.Count);
            List<float> ysList = new List<float>();

            float[] ys; 
            
            for (int i = 0; i < dataPoints.Count; i++)
            {
                ysList[i] = dataPoints[i].dodgeCount;
            }

            ys = ysList.ToArray();

            var dodgeCountLine = new OxyPlot.Series.LineSeries()
            {
                Title = $"Series 2",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 1,
            };

            for (int i = 0; i < dataPoints.Count; i++)
            {
                dodgeCountLine.Points.Add(new OxyPlot.DataPoint(xs[i], ys[i]));
            }

            // create the model and add the lines to it
            var model = new OxyPlot.PlotModel
            {
                Title = $"Line Plot ({dataPoints.Count:N0} points each)"
            };
            model.Series.Add(dodgeCountLine);

            return model;


        }
    }
}

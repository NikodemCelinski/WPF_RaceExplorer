using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceExplorer.Models
{
    public class ChartDataPoint
    {
        public DateTime dateTime;
        public TensorData JStepData = new TensorData();
        public RaceExplorerEnums.chartObstacleEvent raceEvent;
        public int dodgeStreak;
        public int dodgeCount;


        public void FromString(string dataString)
        {
            //18.04.2024 23:59:31;4,6,5,5,2;None;0;0

            string[] data = dataString.Split(';');



            var cultureInfo = new CultureInfo("pl-PL");

            dateTime = DateTime.Parse(data[0], cultureInfo);


            // The example displays the following output:
            //       6/12/2008 00:00:00
        }
    }
}

using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;


namespace RaceExplorer.Views
{
    /// <summary>
    /// Logika interakcji dla klasy StatView.xaml
    /// </summary>
    public partial class StatView : UserControl
    {

        //public PlotModel MyModel { get; private set; }
        public StatView()
        {
            InitializeComponent();
            //this.MyModel = new PlotModel { Title = "Example 1" };
            //this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));

        }
    }
}

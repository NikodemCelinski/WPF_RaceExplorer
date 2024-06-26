﻿using Caliburn.Micro;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceExplorer.ViewModels
{
    public class StatViewModel : Screen
    {
        public StatViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }
        public PlotModel MyModel { get; private set; }
    }

    
}

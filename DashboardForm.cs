using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;

namespace Spend_Smart
{
    public partial class DashboardForm : Form
    {
        private readonly PieChart pieChart;
        public DashboardForm()
        {
            InitializeComponent();

            /*Pie Chart */

            /*pieChart1.Series = new ISeries[]
             {
                 new PieSeries<double> { Name = "Travelling", Values = new double[] { 1500 } },
                 new PieSeries<double> { Name = "Shopping", Values = new double[] { 300 } },
                 new PieSeries<double> { Name = "Other",  Values = new double[] { 500 } },
                 new PieSeries<double> { Name = "Food",  Values = new double[] { 1000 } },
                 new PieSeries<double> { Name = "Rent",  Values = new double[] { 850 } }
             };*/

            pieChart = new PieChart
            {
                Series = new ISeries[]
                {
                    new PieSeries<double>
                    {
                        Name = "Travelling",
                        Values = new double[] { 1500 },
                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsSize = 15,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => $"{"Travelling"}",
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue} of $1600"
                    },
                    new PieSeries<double>
                    {
                        Name = "Shopping",
                        Values = new double[] { 300 },
                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsSize = 15,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => $"{"Shopping"}",
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue} of $500"
                    },
                    new PieSeries<double>
                    {
                        Name = "Other",
                        Values = new double[] { 500 },
                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsSize = 15,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => $"{"Other"}",
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue} of $750"
                    },
                    new PieSeries<double>
                    {
                        Name = "Food",
                        Values = new double[] { 1000 },
                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsSize = 15,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => $"{"Food"}",
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue} of $1100"
                    },
                    new PieSeries<double>
                    {
                        Name = "Rent",
                        Values = new double[] { 850 },
                        DataLabelsPaint = new SolidColorPaint(SKColors.White),
                        DataLabelsSize = 15,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = point => $"{"Rent"}",
                        ToolTipLabelFormatter = point => $"${point.Coordinate.PrimaryValue} of $850"
                    }
                },
                Location = new Point(20, 25),
                Size = new Size(250, 250),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            panel15.Controls.Add(pieChart);


            /*Cartesian Chart Chart */

            cartesianChart1.Series = new ObservableCollection<ISeries>
            {
                new ColumnSeries<int> { Values = new ObservableCollection<int> { 200, 558, 458, 249 }, Fill = new SolidColorPaint(new SKColor(134, 146, 255)) }
            };

            cartesianChart1.XAxes = new List<Axis>
            {
                new Axis { Labels = new string[] { "Food", "Rent", "Travelling", "Shopping" }, IsVisible=false }
            };

            cartesianChart1.YAxes = new List<Axis> { new Axis { Labeler = Labelers.Currency } };
        }

    }
}

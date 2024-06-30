using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spend_Smart
{
    public partial class ExpensesForm : Form
    {
        public ExpensesForm()
        {
            InitializeComponent();

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

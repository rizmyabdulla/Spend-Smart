using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;


namespace Spend_Smart
{
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();

            pieChart1.Series = new ISeries[]
             {
                 new PieSeries<double> { Name = "Travelling", Values = new double[] { 1500 } },
                 new PieSeries<double> { Name = "Shopping", Values = new double[] { 300 } },
                 new PieSeries<double> { Name = "Other",  Values = new double[] { 500 } },
                 new PieSeries<double> { Name = "Food",  Values = new double[] { 1000 } },
                 new PieSeries<double> { Name = "Rent",  Values = new double[] { 850 } }
             };
        }
    }
}

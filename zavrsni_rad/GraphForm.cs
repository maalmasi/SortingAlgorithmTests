using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmTests
{
    public partial class GraphForm : Form 
    {
        public AlgorithmTests testRef;
        public GraphForm(AlgorithmTests test)
        {
            InitializeComponent();

            testRef = test;
            this.Text = "Prikaz rezultata testiranja";
        }

        //display test data to graph on UI
        public void DisplayDataToGraph(string series, int x, double y, int size, float comparisonCount)
        {
            barChart.Series[series].Points.AddXY(x + 1, y);
            lineChart.Series[series].Points.AddXY(size, comparisonCount);
        }

        //display imported data to graph on UI
        public void DisplayDataToGraphFromFile(string series, int x, double y, int size, float comparisonCount)
        {
            if (y != 0)
            {
            barChart.Series[series].Points.AddXY(x + 1, y);
            lineChart.Series[series].Points.AddXY(size, comparisonCount);
            }
        }

        //enable chart series on test start
        //depending on which algorithms are
        //selected
        public void EnableChartSeries()
        {
            for (int i = 0; i < 6; i++)
            {
                if (testRef.algorithms[i])
                {
                    barChart.Series[i].Enabled = true;
                    lineChart.Series[i].Enabled = true;
                }
            }
        }
    }
}

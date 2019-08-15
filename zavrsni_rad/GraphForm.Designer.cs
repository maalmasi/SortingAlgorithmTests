namespace SortingAlgorithmTests
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // barChart
            // 
            chartArea1.AxisX.Title = "Redni broj testa";
            chartArea1.AxisY.Title = "Vrijeme u sekundama";
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 70.60802F;
            chartArea1.InnerPlotPosition.Width = 87.28375F;
            chartArea1.InnerPlotPosition.X = 11.37236F;
            chartArea1.InnerPlotPosition.Y = 13.90957F;
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(12, 12);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Enabled = false;
            series1.IsValueShownAsLabel = true;
            series1.LabelAngle = -90;
            series1.LabelFormat = "{0.00000}";
            series1.Legend = "Legend1";
            series1.Name = "Bubble";
            series1.SmartLabelStyle.Enabled = false;
            series1.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series1.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series2.ChartArea = "ChartArea1";
            series2.Enabled = false;
            series2.IsValueShownAsLabel = true;
            series2.LabelAngle = -90;
            series2.LabelFormat = "{0.00000}";
            series2.Legend = "Legend1";
            series2.Name = "Heap";
            series2.SmartLabelStyle.Enabled = false;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series3.ChartArea = "ChartArea1";
            series3.Enabled = false;
            series3.IsValueShownAsLabel = true;
            series3.LabelAngle = -90;
            series3.LabelFormat = "{0.00000}";
            series3.Legend = "Legend1";
            series3.Name = "Insertion";
            series3.SmartLabelStyle.Enabled = false;
            series3.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series3.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series4.ChartArea = "ChartArea1";
            series4.Enabled = false;
            series4.IsValueShownAsLabel = true;
            series4.LabelAngle = -90;
            series4.LabelFormat = "{0.00000}";
            series4.Legend = "Legend1";
            series4.Name = "Merge";
            series4.SmartLabelStyle.Enabled = false;
            series4.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series4.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series5.ChartArea = "ChartArea1";
            series5.Enabled = false;
            series5.IsValueShownAsLabel = true;
            series5.LabelAngle = -90;
            series5.LabelFormat = "{0.00000}";
            series5.Legend = "Legend1";
            series5.Name = "Quick";
            series5.SmartLabelStyle.Enabled = false;
            series5.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series5.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series6.ChartArea = "ChartArea1";
            series6.Enabled = false;
            series6.IsValueShownAsLabel = true;
            series6.LabelAngle = -90;
            series6.LabelFormat = "{0.00000}";
            series6.Legend = "Legend1";
            series6.Name = "Selection";
            series6.SmartLabelStyle.Enabled = false;
            series6.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series6.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            this.barChart.Series.Add(series1);
            this.barChart.Series.Add(series2);
            this.barChart.Series.Add(series3);
            this.barChart.Series.Add(series4);
            this.barChart.Series.Add(series5);
            this.barChart.Series.Add(series6);
            this.barChart.Size = new System.Drawing.Size(747, 280);
            this.barChart.TabIndex = 41;
            this.barChart.Text = "barChart";
            // 
            // lineChart
            // 
            chartArea2.AxisX.Title = "Veličina polja";
            chartArea2.AxisY.Title = "Broj usporedbi";
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Name = "Legend1";
            this.lineChart.Legends.Add(legend2);
            this.lineChart.Location = new System.Drawing.Point(12, 298);
            this.lineChart.Name = "lineChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Enabled = false;
            series7.Legend = "Legend1";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Bubble";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Enabled = false;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Heap";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Enabled = false;
            series9.Legend = "Legend1";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Insertion";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Enabled = false;
            series10.Legend = "Legend1";
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "Merge";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Enabled = false;
            series11.Legend = "Legend1";
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "Quick";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Enabled = false;
            series12.Legend = "Legend1";
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series12.Name = "Selection";
            this.lineChart.Series.Add(series7);
            this.lineChart.Series.Add(series8);
            this.lineChart.Series.Add(series9);
            this.lineChart.Series.Add(series10);
            this.lineChart.Series.Add(series11);
            this.lineChart.Series.Add(series12);
            this.lineChart.Size = new System.Drawing.Size(747, 280);
            this.lineChart.TabIndex = 42;
            this.lineChart.Text = "lineChart";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 589);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.barChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
    }
}
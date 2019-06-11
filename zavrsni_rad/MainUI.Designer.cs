namespace zavrsni_rad
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStartAlgorithmTests = new System.Windows.Forms.Button();
            this._label_test_count = new System.Windows.Forms.Label();
            this.dropdownTestCount = new System.Windows.Forms.ComboBox();
            this._label_test1 = new System.Windows.Forms.Label();
            this._label_test2 = new System.Windows.Forms.Label();
            this._label_test3 = new System.Windows.Forms.Label();
            this._label_test4 = new System.Windows.Forms.Label();
            this._label_test5 = new System.Windows.Forms.Label();
            this._label_select_algorithm = new System.Windows.Forms.Label();
            this.cbAlgorithmSelectSort = new System.Windows.Forms.CheckBox();
            this.cbAlgorithmBubbleSort = new System.Windows.Forms.CheckBox();
            this.cbAlgorithmInsertionSort = new System.Windows.Forms.CheckBox();
            this.cbAlgorithmQuickSort = new System.Windows.Forms.CheckBox();
            this.cbAlgorithmMergeSort = new System.Windows.Forms.CheckBox();
            this.load_file = new System.Windows.Forms.Button();
            this._label_test_type = new System.Windows.Forms.Label();
            this.dropdownTestType = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._label_file_name = new System.Windows.Forms.Label();
            this.cbAlgorithmHeapSort = new System.Windows.Forms.CheckBox();
            this.tbToolTip = new System.Windows.Forms.ToolTip(this.components);
            this._label_min_value = new System.Windows.Forms.Label();
            this._label_max_value = new System.Windows.Forms.Label();
            this.tbTest1 = new System.Windows.Forms.NumericUpDown();
            this.tbTest2 = new System.Windows.Forms.NumericUpDown();
            this.tbTest3 = new System.Windows.Forms.NumericUpDown();
            this.tbTest4 = new System.Windows.Forms.NumericUpDown();
            this.tbTest5 = new System.Windows.Forms.NumericUpDown();
            this.tbMinValue = new System.Windows.Forms.NumericUpDown();
            this.tbMaxValue = new System.Windows.Forms.NumericUpDown();
            this.testProgress = new System.Windows.Forms.ProgressBar();
            this.btnSaveTestResults = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStopTesting = new System.Windows.Forms.Button();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClearChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartAlgorithmTests
            // 
            this.btnStartAlgorithmTests.Location = new System.Drawing.Point(252, 226);
            this.btnStartAlgorithmTests.Name = "btnStartAlgorithmTests";
            this.btnStartAlgorithmTests.Size = new System.Drawing.Size(90, 23);
            this.btnStartAlgorithmTests.TabIndex = 0;
            this.btnStartAlgorithmTests.Text = "Pokreni";
            this.btnStartAlgorithmTests.UseVisualStyleBackColor = true;
            this.btnStartAlgorithmTests.Click += new System.EventHandler(this.btnStartAlgorithmTests_Click);
            // 
            // _label_test_count
            // 
            this._label_test_count.AutoSize = true;
            this._label_test_count.Location = new System.Drawing.Point(12, 115);
            this._label_test_count.Name = "_label_test_count";
            this._label_test_count.Size = new System.Drawing.Size(63, 13);
            this._label_test_count.TabIndex = 1;
            this._label_test_count.Text = "Broj testova";
            // 
            // dropdownTestCount
            // 
            this.dropdownTestCount.Enabled = false;
            this.dropdownTestCount.FormattingEnabled = true;
            this.dropdownTestCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dropdownTestCount.Location = new System.Drawing.Point(15, 131);
            this.dropdownTestCount.Name = "dropdownTestCount";
            this.dropdownTestCount.Size = new System.Drawing.Size(60, 21);
            this.dropdownTestCount.TabIndex = 2;
            this.dropdownTestCount.SelectedIndexChanged += new System.EventHandler(this.dropdownTestCount_SelectedIndexChanged);
            // 
            // _label_test1
            // 
            this._label_test1.AutoSize = true;
            this._label_test1.Location = new System.Drawing.Point(109, 114);
            this._label_test1.Name = "_label_test1";
            this._label_test1.Size = new System.Drawing.Size(36, 13);
            this._label_test1.TabIndex = 8;
            this._label_test1.Text = "1. test";
            // 
            // _label_test2
            // 
            this._label_test2.AutoSize = true;
            this._label_test2.Location = new System.Drawing.Point(249, 114);
            this._label_test2.Name = "_label_test2";
            this._label_test2.Size = new System.Drawing.Size(36, 13);
            this._label_test2.TabIndex = 9;
            this._label_test2.Text = "2. test";
            // 
            // _label_test3
            // 
            this._label_test3.AutoSize = true;
            this._label_test3.Location = new System.Drawing.Point(389, 114);
            this._label_test3.Name = "_label_test3";
            this._label_test3.Size = new System.Drawing.Size(36, 13);
            this._label_test3.TabIndex = 10;
            this._label_test3.Text = "3. test";
            // 
            // _label_test4
            // 
            this._label_test4.AutoSize = true;
            this._label_test4.Location = new System.Drawing.Point(529, 114);
            this._label_test4.Name = "_label_test4";
            this._label_test4.Size = new System.Drawing.Size(36, 13);
            this._label_test4.TabIndex = 11;
            this._label_test4.Text = "4. test";
            // 
            // _label_test5
            // 
            this._label_test5.AutoSize = true;
            this._label_test5.Location = new System.Drawing.Point(669, 115);
            this._label_test5.Name = "_label_test5";
            this._label_test5.Size = new System.Drawing.Size(36, 13);
            this._label_test5.TabIndex = 12;
            this._label_test5.Text = "5. test";
            // 
            // _label_select_algorithm
            // 
            this._label_select_algorithm.AutoSize = true;
            this._label_select_algorithm.Location = new System.Drawing.Point(12, 58);
            this._label_select_algorithm.Name = "_label_select_algorithm";
            this._label_select_algorithm.Size = new System.Drawing.Size(46, 13);
            this._label_select_algorithm.TabIndex = 13;
            this._label_select_algorithm.Text = "Algoritmi";
            // 
            // cbAlgorithmSelectSort
            // 
            this.cbAlgorithmSelectSort.AutoSize = true;
            this.cbAlgorithmSelectSort.Enabled = false;
            this.cbAlgorithmSelectSort.Location = new System.Drawing.Point(392, 80);
            this.cbAlgorithmSelectSort.Name = "cbAlgorithmSelectSort";
            this.cbAlgorithmSelectSort.Size = new System.Drawing.Size(90, 17);
            this.cbAlgorithmSelectSort.TabIndex = 15;
            this.cbAlgorithmSelectSort.Text = "Selection sort";
            this.cbAlgorithmSelectSort.UseVisualStyleBackColor = true;
            // 
            // cbAlgorithmBubbleSort
            // 
            this.cbAlgorithmBubbleSort.AutoSize = true;
            this.cbAlgorithmBubbleSort.Enabled = false;
            this.cbAlgorithmBubbleSort.Location = new System.Drawing.Point(112, 57);
            this.cbAlgorithmBubbleSort.Name = "cbAlgorithmBubbleSort";
            this.cbAlgorithmBubbleSort.Size = new System.Drawing.Size(79, 17);
            this.cbAlgorithmBubbleSort.TabIndex = 16;
            this.cbAlgorithmBubbleSort.Text = "Bubble sort";
            this.cbAlgorithmBubbleSort.UseVisualStyleBackColor = true;
            // 
            // cbAlgorithmInsertionSort
            // 
            this.cbAlgorithmInsertionSort.AutoSize = true;
            this.cbAlgorithmInsertionSort.Enabled = false;
            this.cbAlgorithmInsertionSort.Location = new System.Drawing.Point(392, 57);
            this.cbAlgorithmInsertionSort.Name = "cbAlgorithmInsertionSort";
            this.cbAlgorithmInsertionSort.Size = new System.Drawing.Size(86, 17);
            this.cbAlgorithmInsertionSort.TabIndex = 17;
            this.cbAlgorithmInsertionSort.Text = "Insertion sort";
            this.cbAlgorithmInsertionSort.UseVisualStyleBackColor = true;
            // 
            // cbAlgorithmQuickSort
            // 
            this.cbAlgorithmQuickSort.AutoSize = true;
            this.cbAlgorithmQuickSort.Enabled = false;
            this.cbAlgorithmQuickSort.Location = new System.Drawing.Point(252, 80);
            this.cbAlgorithmQuickSort.Name = "cbAlgorithmQuickSort";
            this.cbAlgorithmQuickSort.Size = new System.Drawing.Size(74, 17);
            this.cbAlgorithmQuickSort.TabIndex = 18;
            this.cbAlgorithmQuickSort.Text = "Quick sort";
            this.cbAlgorithmQuickSort.UseVisualStyleBackColor = true;
            // 
            // cbAlgorithmMergeSort
            // 
            this.cbAlgorithmMergeSort.AutoSize = true;
            this.cbAlgorithmMergeSort.Enabled = false;
            this.cbAlgorithmMergeSort.Location = new System.Drawing.Point(112, 80);
            this.cbAlgorithmMergeSort.Name = "cbAlgorithmMergeSort";
            this.cbAlgorithmMergeSort.Size = new System.Drawing.Size(76, 17);
            this.cbAlgorithmMergeSort.TabIndex = 19;
            this.cbAlgorithmMergeSort.Text = "Merge sort";
            this.cbAlgorithmMergeSort.UseVisualStyleBackColor = true;
            // 
            // load_file
            // 
            this.load_file.Enabled = false;
            this.load_file.Location = new System.Drawing.Point(392, 16);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(100, 23);
            this.load_file.TabIndex = 20;
            this.load_file.Text = "Odabir datoteke";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.load_file_Click);
            // 
            // _label_test_type
            // 
            this._label_test_type.AutoSize = true;
            this._label_test_type.Location = new System.Drawing.Point(12, 21);
            this._label_test_type.Name = "_label_test_type";
            this._label_test_type.Size = new System.Drawing.Size(76, 13);
            this._label_test_type.TabIndex = 21;
            this._label_test_type.Text = "Vrsta testiranja";
            // 
            // dropdownTestType
            // 
            this.dropdownTestType.FormattingEnabled = true;
            this.dropdownTestType.Items.AddRange(new object[] {
            "Psudoslučajne vrijednosti",
            "Podaci iz vanjske datoteke"});
            this.dropdownTestType.Location = new System.Drawing.Point(115, 18);
            this.dropdownTestType.Name = "dropdownTestType";
            this.dropdownTestType.Size = new System.Drawing.Size(160, 21);
            this.dropdownTestType.TabIndex = 22;
            this.dropdownTestType.SelectedIndexChanged += new System.EventHandler(this.dropdownTestType_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Json|*.json";
            // 
            // _label_file_name
            // 
            this._label_file_name.AutoSize = true;
            this._label_file_name.Location = new System.Drawing.Point(529, 21);
            this._label_file_name.Name = "_label_file_name";
            this._label_file_name.Size = new System.Drawing.Size(69, 13);
            this._label_file_name.TabIndex = 23;
            this._label_file_name.Text = "Ime datoteke";
            // 
            // cbAlgorithmHeapSort
            // 
            this.cbAlgorithmHeapSort.AutoSize = true;
            this.cbAlgorithmHeapSort.Enabled = false;
            this.cbAlgorithmHeapSort.Location = new System.Drawing.Point(252, 57);
            this.cbAlgorithmHeapSort.Name = "cbAlgorithmHeapSort";
            this.cbAlgorithmHeapSort.Size = new System.Drawing.Size(72, 17);
            this.cbAlgorithmHeapSort.TabIndex = 24;
            this.cbAlgorithmHeapSort.Text = "Heap sort";
            this.cbAlgorithmHeapSort.UseVisualStyleBackColor = true;
            // 
            // tbToolTip
            // 
            this.tbToolTip.ShowAlways = true;
            // 
            // _label_min_value
            // 
            this._label_min_value.AutoSize = true;
            this._label_min_value.Location = new System.Drawing.Point(31, 180);
            this._label_min_value.Name = "_label_min_value";
            this._label_min_value.Size = new System.Drawing.Size(174, 13);
            this._label_min_value.TabIndex = 25;
            this._label_min_value.Text = "Najmanja moguća vrijednost u polju";
            // 
            // _label_max_value
            // 
            this._label_max_value.AutoSize = true;
            this._label_max_value.Location = new System.Drawing.Point(462, 180);
            this._label_max_value.Name = "_label_max_value";
            this._label_max_value.Size = new System.Drawing.Size(170, 13);
            this._label_max_value.TabIndex = 27;
            this._label_max_value.Text = "Najveća moguća vrijednost u polju";
            // 
            // tbTest1
            // 
            this.tbTest1.Enabled = false;
            this.tbTest1.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest1.Location = new System.Drawing.Point(115, 132);
            this.tbTest1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.tbTest1.Name = "tbTest1";
            this.tbTest1.Size = new System.Drawing.Size(90, 20);
            this.tbTest1.TabIndex = 29;
            // 
            // tbTest2
            // 
            this.tbTest2.Enabled = false;
            this.tbTest2.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest2.Location = new System.Drawing.Point(252, 132);
            this.tbTest2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.tbTest2.Name = "tbTest2";
            this.tbTest2.Size = new System.Drawing.Size(90, 20);
            this.tbTest2.TabIndex = 30;
            // 
            // tbTest3
            // 
            this.tbTest3.Enabled = false;
            this.tbTest3.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest3.Location = new System.Drawing.Point(392, 132);
            this.tbTest3.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.tbTest3.Name = "tbTest3";
            this.tbTest3.Size = new System.Drawing.Size(90, 20);
            this.tbTest3.TabIndex = 31;
            // 
            // tbTest4
            // 
            this.tbTest4.Enabled = false;
            this.tbTest4.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest4.Location = new System.Drawing.Point(532, 132);
            this.tbTest4.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.tbTest4.Name = "tbTest4";
            this.tbTest4.Size = new System.Drawing.Size(90, 20);
            this.tbTest4.TabIndex = 32;
            // 
            // tbTest5
            // 
            this.tbTest5.Enabled = false;
            this.tbTest5.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest5.Location = new System.Drawing.Point(672, 132);
            this.tbTest5.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.tbTest5.Name = "tbTest5";
            this.tbTest5.Size = new System.Drawing.Size(90, 20);
            this.tbTest5.TabIndex = 33;
            // 
            // tbMinValue
            // 
            this.tbMinValue.Enabled = false;
            this.tbMinValue.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbMinValue.Location = new System.Drawing.Point(252, 178);
            this.tbMinValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.tbMinValue.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.Size = new System.Drawing.Size(90, 20);
            this.tbMinValue.TabIndex = 34;
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Enabled = false;
            this.tbMaxValue.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbMaxValue.Location = new System.Drawing.Point(672, 178);
            this.tbMaxValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.tbMaxValue.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(90, 20);
            this.tbMaxValue.TabIndex = 35;
            // 
            // testProgress
            // 
            this.testProgress.Location = new System.Drawing.Point(15, 226);
            this.testProgress.Name = "testProgress";
            this.testProgress.Size = new System.Drawing.Size(190, 23);
            this.testProgress.TabIndex = 36;
            // 
            // btnSaveTestResults
            // 
            this.btnSaveTestResults.Enabled = false;
            this.btnSaveTestResults.Location = new System.Drawing.Point(672, 226);
            this.btnSaveTestResults.Name = "btnSaveTestResults";
            this.btnSaveTestResults.Size = new System.Drawing.Size(90, 23);
            this.btnSaveTestResults.TabIndex = 37;
            this.btnSaveTestResults.Text = "Spremi rezultate";
            this.btnSaveTestResults.UseVisualStyleBackColor = true;
            this.btnSaveTestResults.Click += new System.EventHandler(this.btnSaveTestResults_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.Filter = "Json|*.json";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // btnStopTesting
            // 
            this.btnStopTesting.Enabled = false;
            this.btnStopTesting.Location = new System.Drawing.Point(392, 226);
            this.btnStopTesting.Name = "btnStopTesting";
            this.btnStopTesting.Size = new System.Drawing.Size(90, 23);
            this.btnStopTesting.TabIndex = 39;
            this.btnStopTesting.Text = "Zaustavi";
            this.btnStopTesting.UseVisualStyleBackColor = true;
            this.btnStopTesting.Click += new System.EventHandler(this.btnStopTesting_Click);
            // 
            // barChart
            // 
            chartArea3.AxisX.Title = "Redni broj testa";
            chartArea3.AxisY.Title = "Vrijeme u sekundama";
            chartArea3.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.barChart.Legends.Add(legend3);
            this.barChart.Location = new System.Drawing.Point(15, 276);
            this.barChart.Name = "barChart";
            series13.ChartArea = "ChartArea1";
            series13.IsValueShownAsLabel = true;
            series13.LabelAngle = -90;
            series13.LabelFormat = "{0.00000}";
            series13.Legend = "Legend1";
            series13.Name = "Bubble";
            series13.SmartLabelStyle.Enabled = false;
            series13.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series13.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series14.ChartArea = "ChartArea1";
            series14.IsValueShownAsLabel = true;
            series14.LabelAngle = -90;
            series14.LabelFormat = "{0.00000}";
            series14.Legend = "Legend1";
            series14.Name = "Heap";
            series14.SmartLabelStyle.Enabled = false;
            series14.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series14.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series15.ChartArea = "ChartArea1";
            series15.IsValueShownAsLabel = true;
            series15.LabelAngle = -90;
            series15.LabelFormat = "{0.00000}";
            series15.Legend = "Legend1";
            series15.Name = "Insertion";
            series15.SmartLabelStyle.Enabled = false;
            series15.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series15.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series16.ChartArea = "ChartArea1";
            series16.IsValueShownAsLabel = true;
            series16.LabelAngle = -90;
            series16.LabelFormat = "{0.00000}";
            series16.Legend = "Legend1";
            series16.Name = "Merge";
            series16.SmartLabelStyle.Enabled = false;
            series16.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series16.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series17.ChartArea = "ChartArea1";
            series17.IsValueShownAsLabel = true;
            series17.LabelAngle = -90;
            series17.LabelFormat = "{0.00000}";
            series17.Legend = "Legend1";
            series17.Name = "Quick";
            series17.SmartLabelStyle.Enabled = false;
            series17.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series17.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series18.ChartArea = "ChartArea1";
            series18.IsValueShownAsLabel = true;
            series18.LabelAngle = -90;
            series18.LabelFormat = "{0.00000}";
            series18.Legend = "Legend1";
            series18.Name = "Selection";
            series18.SmartLabelStyle.Enabled = false;
            series18.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series18.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            this.barChart.Series.Add(series13);
            this.barChart.Series.Add(series14);
            this.barChart.Series.Add(series15);
            this.barChart.Series.Add(series16);
            this.barChart.Series.Add(series17);
            this.barChart.Series.Add(series18);
            this.barChart.Size = new System.Drawing.Size(747, 280);
            this.barChart.TabIndex = 40;
            this.barChart.Text = "barChart";
            // 
            // lineChart
            // 
            chartArea4.AxisX.Title = "Veličina polja";
            chartArea4.AxisY.Title = "Vrijeme u sekundama";
            chartArea4.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.lineChart.Legends.Add(legend4);
            this.lineChart.Location = new System.Drawing.Point(12, 562);
            this.lineChart.Name = "lineChart";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Bubble";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Heap";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Insertion";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Merge";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Quick";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "Selection";
            this.lineChart.Series.Add(series19);
            this.lineChart.Series.Add(series20);
            this.lineChart.Series.Add(series21);
            this.lineChart.Series.Add(series22);
            this.lineChart.Series.Add(series23);
            this.lineChart.Series.Add(series24);
            this.lineChart.Size = new System.Drawing.Size(747, 280);
            this.lineChart.TabIndex = 41;
            this.lineChart.Text = "lineChart";
            // 
            // btnClearChart
            // 
            this.btnClearChart.Enabled = false;
            this.btnClearChart.Location = new System.Drawing.Point(532, 226);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(90, 23);
            this.btnClearChart.TabIndex = 42;
            this.btnClearChart.Text = "Isprazni grafove";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 843);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.btnStopTesting);
            this.Controls.Add(this.btnSaveTestResults);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.tbMinValue);
            this.Controls.Add(this.tbTest5);
            this.Controls.Add(this.tbTest4);
            this.Controls.Add(this.tbTest3);
            this.Controls.Add(this.tbTest2);
            this.Controls.Add(this.tbTest1);
            this.Controls.Add(this._label_max_value);
            this.Controls.Add(this._label_min_value);
            this.Controls.Add(this.cbAlgorithmHeapSort);
            this.Controls.Add(this._label_file_name);
            this.Controls.Add(this._label_test5);
            this.Controls.Add(this._label_test4);
            this.Controls.Add(this._label_test3);
            this.Controls.Add(this._label_test2);
            this.Controls.Add(this._label_test1);
            this.Controls.Add(this.dropdownTestCount);
            this.Controls.Add(this._label_test_count);
            this.Controls.Add(this.dropdownTestType);
            this.Controls.Add(this._label_test_type);
            this.Controls.Add(this.load_file);
            this.Controls.Add(this.cbAlgorithmMergeSort);
            this.Controls.Add(this.cbAlgorithmQuickSort);
            this.Controls.Add(this.cbAlgorithmInsertionSort);
            this.Controls.Add(this.cbAlgorithmBubbleSort);
            this.Controls.Add(this.cbAlgorithmSelectSort);
            this.Controls.Add(this._label_select_algorithm);
            this.Controls.Add(this.btnStartAlgorithmTests);
            this.Controls.Add(this.testProgress);
            this.Name = "MainUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _label_test_count;
        private System.Windows.Forms.ComboBox dropdownTestCount;
        private System.Windows.Forms.Label _label_test1;
        private System.Windows.Forms.Label _label_test2;
        private System.Windows.Forms.Label _label_test3;
        private System.Windows.Forms.Label _label_test4;
        private System.Windows.Forms.Label _label_test5;
        private System.Windows.Forms.Label _label_select_algorithm;
        private System.Windows.Forms.CheckBox cbAlgorithmSelectSort;
        private System.Windows.Forms.CheckBox cbAlgorithmBubbleSort;
        private System.Windows.Forms.CheckBox cbAlgorithmInsertionSort;
        private System.Windows.Forms.CheckBox cbAlgorithmQuickSort;
        private System.Windows.Forms.CheckBox cbAlgorithmMergeSort;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.Label _label_test_type;
        private System.Windows.Forms.ComboBox dropdownTestType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label _label_file_name;
        private System.Windows.Forms.CheckBox cbAlgorithmHeapSort;
        private System.Windows.Forms.ToolTip tbToolTip;
        private System.Windows.Forms.Label _label_min_value;
        private System.Windows.Forms.Label _label_max_value;
        private System.Windows.Forms.NumericUpDown tbTest1;
        private System.Windows.Forms.NumericUpDown tbTest2;
        private System.Windows.Forms.NumericUpDown tbTest3;
        private System.Windows.Forms.NumericUpDown tbTest4;
        private System.Windows.Forms.NumericUpDown tbTest5;
        private System.Windows.Forms.NumericUpDown tbMinValue;
        private System.Windows.Forms.NumericUpDown tbMaxValue;
        public System.Windows.Forms.ProgressBar testProgress;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btnStartAlgorithmTests;
        public System.Windows.Forms.Button btnSaveTestResults;
        public System.Windows.Forms.Button btnStopTesting;
        public System.Windows.Forms.Button btnClearChart;
    }
}


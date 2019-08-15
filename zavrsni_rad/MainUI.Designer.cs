namespace SortingAlgorithmTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.btnStartAlgorithmTests = new System.Windows.Forms.Button();
            this._label_test_count = new System.Windows.Forms.Label();
            this.dropdownTestCount = new System.Windows.Forms.ComboBox();
            this._label_test1 = new System.Windows.Forms.Label();
            this._label_test2 = new System.Windows.Forms.Label();
            this._label_test3 = new System.Windows.Forms.Label();
            this._label_test4 = new System.Windows.Forms.Label();
            this._label_test5 = new System.Windows.Forms.Label();
            this.load_file = new System.Windows.Forms.Button();
            this.dropdownTestType = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._label_file_name = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAlgs = new System.Windows.Forms.ListBox();
            this.btnAddRemoveAlgs = new System.Windows.Forms.Button();
            this.clbAlgorithms = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAlgorithmTests
            // 
            this.btnStartAlgorithmTests.Location = new System.Drawing.Point(18, 34);
            this.btnStartAlgorithmTests.Name = "btnStartAlgorithmTests";
            this.btnStartAlgorithmTests.Size = new System.Drawing.Size(180, 23);
            this.btnStartAlgorithmTests.TabIndex = 0;
            this.btnStartAlgorithmTests.Text = "Pokreni";
            this.btnStartAlgorithmTests.UseVisualStyleBackColor = true;
            this.btnStartAlgorithmTests.Click += new System.EventHandler(this.btnStartAlgorithmTests_Click);
            // 
            // _label_test_count
            // 
            this._label_test_count.AutoSize = true;
            this._label_test_count.Location = new System.Drawing.Point(23, 21);
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
            this.dropdownTestCount.Location = new System.Drawing.Point(26, 37);
            this.dropdownTestCount.Name = "dropdownTestCount";
            this.dropdownTestCount.Size = new System.Drawing.Size(60, 21);
            this.dropdownTestCount.TabIndex = 2;
            this.dropdownTestCount.SelectedIndexChanged += new System.EventHandler(this.dropdownTestCount_SelectedIndexChanged);
            // 
            // _label_test1
            // 
            this._label_test1.AutoSize = true;
            this._label_test1.Location = new System.Drawing.Point(133, 21);
            this._label_test1.Name = "_label_test1";
            this._label_test1.Size = new System.Drawing.Size(36, 13);
            this._label_test1.TabIndex = 8;
            this._label_test1.Text = "1. test";
            // 
            // _label_test2
            // 
            this._label_test2.AutoSize = true;
            this._label_test2.Location = new System.Drawing.Point(244, 22);
            this._label_test2.Name = "_label_test2";
            this._label_test2.Size = new System.Drawing.Size(36, 13);
            this._label_test2.TabIndex = 9;
            this._label_test2.Text = "2. test";
            // 
            // _label_test3
            // 
            this._label_test3.AutoSize = true;
            this._label_test3.Location = new System.Drawing.Point(23, 75);
            this._label_test3.Name = "_label_test3";
            this._label_test3.Size = new System.Drawing.Size(36, 13);
            this._label_test3.TabIndex = 10;
            this._label_test3.Text = "3. test";
            // 
            // _label_test4
            // 
            this._label_test4.AutoSize = true;
            this._label_test4.Location = new System.Drawing.Point(133, 75);
            this._label_test4.Name = "_label_test4";
            this._label_test4.Size = new System.Drawing.Size(36, 13);
            this._label_test4.TabIndex = 11;
            this._label_test4.Text = "4. test";
            // 
            // _label_test5
            // 
            this._label_test5.AutoSize = true;
            this._label_test5.Location = new System.Drawing.Point(244, 75);
            this._label_test5.Name = "_label_test5";
            this._label_test5.Size = new System.Drawing.Size(36, 13);
            this._label_test5.TabIndex = 12;
            this._label_test5.Text = "5. test";
            // 
            // load_file
            // 
            this.load_file.Enabled = false;
            this.load_file.Location = new System.Drawing.Point(237, 37);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(100, 23);
            this.load_file.TabIndex = 20;
            this.load_file.Text = "Odabir datoteke";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.load_file_Click);
            // 
            // dropdownTestType
            // 
            this.dropdownTestType.FormattingEnabled = true;
            this.dropdownTestType.Items.AddRange(new object[] {
            "Psudoslučajne vrijednosti",
            "Podaci iz vanjske datoteke"});
            this.dropdownTestType.Location = new System.Drawing.Point(19, 39);
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
            this._label_file_name.Location = new System.Drawing.Point(374, 42);
            this._label_file_name.Name = "_label_file_name";
            this._label_file_name.Size = new System.Drawing.Size(69, 13);
            this._label_file_name.TabIndex = 23;
            this._label_file_name.Text = "Ime datoteke";
            // 
            // tbToolTip
            // 
            this.tbToolTip.ShowAlways = true;
            // 
            // _label_min_value
            // 
            this._label_min_value.AutoSize = true;
            this._label_min_value.Location = new System.Drawing.Point(23, 133);
            this._label_min_value.Name = "_label_min_value";
            this._label_min_value.Size = new System.Drawing.Size(73, 13);
            this._label_min_value.TabIndex = 25;
            this._label_min_value.Text = "Donja granica";
            // 
            // _label_max_value
            // 
            this._label_max_value.AutoSize = true;
            this._label_max_value.Location = new System.Drawing.Point(133, 133);
            this._label_max_value.Name = "_label_max_value";
            this._label_max_value.Size = new System.Drawing.Size(76, 13);
            this._label_max_value.TabIndex = 27;
            this._label_max_value.Text = "Gornja granica";
            // 
            // tbTest1
            // 
            this.tbTest1.Enabled = false;
            this.tbTest1.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTest1.Location = new System.Drawing.Point(136, 38);
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
            this.tbTest2.Location = new System.Drawing.Point(247, 38);
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
            this.tbTest3.Location = new System.Drawing.Point(26, 91);
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
            this.tbTest4.Location = new System.Drawing.Point(136, 91);
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
            this.tbTest5.Location = new System.Drawing.Point(247, 91);
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
            this.tbMinValue.Location = new System.Drawing.Point(26, 149);
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
            this.tbMaxValue.Location = new System.Drawing.Point(136, 149);
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
            this.testProgress.Location = new System.Drawing.Point(12, 393);
            this.testProgress.Name = "testProgress";
            this.testProgress.Size = new System.Drawing.Size(747, 23);
            this.testProgress.TabIndex = 36;
            // 
            // btnSaveTestResults
            // 
            this.btnSaveTestResults.Enabled = false;
            this.btnSaveTestResults.Location = new System.Drawing.Point(529, 34);
            this.btnSaveTestResults.Name = "btnSaveTestResults";
            this.btnSaveTestResults.Size = new System.Drawing.Size(180, 23);
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
            this.btnStopTesting.Location = new System.Drawing.Point(269, 34);
            this.btnStopTesting.Name = "btnStopTesting";
            this.btnStopTesting.Size = new System.Drawing.Size(180, 23);
            this.btnStopTesting.TabIndex = 39;
            this.btnStopTesting.Text = "Zaustavi";
            this.btnStopTesting.UseVisualStyleBackColor = true;
            this.btnStopTesting.Click += new System.EventHandler(this.btnStopTesting_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropdownTestType);
            this.groupBox1.Controls.Add(this.load_file);
            this.groupBox1.Controls.Add(this._label_file_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 78);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta testiranja i odabir datoteke";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbAlgs);
            this.groupBox2.Controls.Add(this.btnAddRemoveAlgs);
            this.groupBox2.Controls.Add(this.clbAlgorithms);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 196);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir algoritama";
            // 
            // lbAlgs
            // 
            this.lbAlgs.Enabled = false;
            this.lbAlgs.FormattingEnabled = true;
            this.lbAlgs.Location = new System.Drawing.Point(185, 38);
            this.lbAlgs.Name = "lbAlgs";
            this.lbAlgs.Size = new System.Drawing.Size(120, 95);
            this.lbAlgs.TabIndex = 42;
            // 
            // btnAddRemoveAlgs
            // 
            this.btnAddRemoveAlgs.Enabled = false;
            this.btnAddRemoveAlgs.Location = new System.Drawing.Point(19, 150);
            this.btnAddRemoveAlgs.Name = "btnAddRemoveAlgs";
            this.btnAddRemoveAlgs.Size = new System.Drawing.Size(286, 23);
            this.btnAddRemoveAlgs.TabIndex = 2;
            this.btnAddRemoveAlgs.Text = "Dodaj/ukloni algoritme";
            this.btnAddRemoveAlgs.UseVisualStyleBackColor = true;
            this.btnAddRemoveAlgs.Click += new System.EventHandler(this.btnAddRemoveAlgs_Click);
            // 
            // clbAlgorithms
            // 
            this.clbAlgorithms.CheckOnClick = true;
            this.clbAlgorithms.Enabled = false;
            this.clbAlgorithms.FormattingEnabled = true;
            this.clbAlgorithms.Items.AddRange(new object[] {
            "Bubble sort",
            "Heap sort",
            "Insertion sort",
            "Merge sort",
            "Quick sort",
            "Selection sort"});
            this.clbAlgorithms.Location = new System.Drawing.Point(19, 38);
            this.clbAlgorithms.Name = "clbAlgorithms";
            this.clbAlgorithms.Size = new System.Drawing.Size(120, 94);
            this.clbAlgorithms.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dropdownTestCount);
            this.groupBox3.Controls.Add(this._label_test_count);
            this.groupBox3.Controls.Add(this._label_test1);
            this.groupBox3.Controls.Add(this.tbTest1);
            this.groupBox3.Controls.Add(this.tbTest2);
            this.groupBox3.Controls.Add(this.tbMaxValue);
            this.groupBox3.Controls.Add(this.tbTest3);
            this.groupBox3.Controls.Add(this._label_max_value);
            this.groupBox3.Controls.Add(this.tbMinValue);
            this.groupBox3.Controls.Add(this._label_min_value);
            this.groupBox3.Controls.Add(this._label_test2);
            this.groupBox3.Controls.Add(this.tbTest5);
            this.groupBox3.Controls.Add(this._label_test3);
            this.groupBox3.Controls.Add(this._label_test5);
            this.groupBox3.Controls.Add(this.tbTest4);
            this.groupBox3.Controls.Add(this._label_test4);
            this.groupBox3.Location = new System.Drawing.Point(346, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 195);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Broj testova i postavke polja";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStartAlgorithmTests);
            this.groupBox4.Controls.Add(this.btnStopTesting);
            this.groupBox4.Controls.Add(this.btnSaveTestResults);
            this.groupBox4.Location = new System.Drawing.Point(13, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(746, 78);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Upravljanje testom";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 426);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.testProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbTest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTest5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _label_test_count;
        private System.Windows.Forms.ComboBox dropdownTestCount;
        private System.Windows.Forms.Label _label_test1;
        private System.Windows.Forms.Label _label_test2;
        private System.Windows.Forms.Label _label_test3;
        private System.Windows.Forms.Label _label_test4;
        private System.Windows.Forms.Label _label_test5;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.ComboBox dropdownTestType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label _label_file_name;
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
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btnStartAlgorithmTests;
        public System.Windows.Forms.Button btnSaveTestResults;
        public System.Windows.Forms.Button btnStopTesting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbAlgorithms;
        private System.Windows.Forms.Button btnAddRemoveAlgs;
        private System.Windows.Forms.ListBox lbAlgs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace zavrsni_rad
{
    public partial class MainUI : Form
    {
        private CheckBox[] checkBoxes;
        private NumericUpDown[] numericUpDowns;
        private NumericUpDown[] numericUpDownsMinMax;
        bool[] algorithms = new bool[6];
        int n_rep, min, max;
        int[] array_size = new int[5];
        string newFileName, newJsonFileName, newArrayFileName;
        AlgorithmTests test;
        public Stopwatch swatch;
        public int chartSeriesOrdinal = 0;

        public MainUI()
        {
            InitializeComponent();

            numericUpDowns = new NumericUpDown[] { tbTest1, tbTest2, tbTest3, tbTest4, tbTest5 };
            checkBoxes = new CheckBox[] { cbAlgorithmBubbleSort, cbAlgorithmHeapSort, cbAlgorithmInsertionSort, cbAlgorithmMergeSort, cbAlgorithmQuickSort, cbAlgorithmSelectSort };
            numericUpDownsMinMax = new NumericUpDown[] { tbMinValue, tbMaxValue };
            this.Text = "Aplikacija za testiranje algoritama sortiranja";
            _label_file_name.Text = "Ime datoteke";
            AlgorithmTests test = new AlgorithmTests();
            InitializeBackgroundWorkerHandlers();
        }

        public void btnStartAlgorithmTests_Click(object sender, EventArgs e)
            //"start test" button funcitonality
        {
            if (dropdownTestType.SelectedItem == null)
            {
                MessageBox.Show(
                    "Niste odabrali vrstu testa!", 
                    "Greška", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
                Console.WriteLine(this);
            }

            else if (!CheckCheckBoxes() && dropdownTestType.SelectedIndex == 0)
            {
                    MessageBox.Show(
                        "Niste odabrali nijedan algoritam!", 
                        "Greška", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
            }

            else if (!CheckTestCount() && dropdownTestType.SelectedIndex == 0)
            {
                    MessageBox.Show(
                        "Niste odabrali broj testova!", 
                        "Greška", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
            }

            else if (!CheckTextBoxes() && dropdownTestType.SelectedIndex == 0)
            {
                    MessageBox.Show("Niste unijeli veličinu polja!", "Greška", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (tbMinValue.Value > tbMaxValue.Value)
            {
                MessageBox.Show("Minimalna vrijednost u polju mora biti manja od maksimalne!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (tbMinValue.Value == tbMaxValue.Value)
            {
                MessageBox.Show("Minimalna i maksimalna vrijednost ne smiju biti iste!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (dropdownTestType.SelectedIndex == 0)
                {
                    GetDataFromUI();
                    test = new AlgorithmTests(algorithms, n_rep, array_size, min, max);
                    test.GetMainReference(this);
                }
                btnStartAlgorithmTests.Enabled = false;
                btnStopTesting.Enabled = true;
                SetTimer();
                RunAlgorithmTests();
            }
        }

        private void SetTimer()
            //start a timer to time the entire test
        {
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            swatch = new Stopwatch();
            swatch.Start();
        }

        private void TimerTick(object sender, EventArgs e)
            //timer event to display time
        {
            this.Text = "Proteklo vrijeme: "
                + swatch.Elapsed.Hours.ToString() + ":"
                + swatch.Elapsed.Minutes.ToString() + ":"
                + swatch.Elapsed.Seconds.ToString();
        }

        private void RunAlgorithmTests()
            //background worker to do the testing
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void InitializeBackgroundWorkerHandlers()
        {
            backgroundWorker.DoWork += (s, e) =>
            {
                test.RunTests();
            };

            backgroundWorker.RunWorkerCompleted += (s, e) =>
            {
                timer.Stop();
                swatch.Stop();
                ShowCompleteMessage();
                btnClearChart.Enabled = true;
                btnStopTesting.Enabled = false;
                btnSaveTestResults.Enabled = true;
                btnStartAlgorithmTests.Enabled = true;
            };
        }

        private void ShowCompleteMessage()
            //show this message on successful test complete
        {
            string title = "Test završen!";
            string message = "Test završen nakon"
                + swatch.Elapsed.Hours.ToString() + ":"
                + swatch.Elapsed.Minutes.ToString() + ":"
                + swatch.Elapsed.Seconds.ToString();
            this.Text = "Aplikacija za testiranje algoritama sortiranja";
            if (test.complete)
            {
                MessageBox.Show(message, title);
            }
        }

        private void btnStopTesting_Click(object sender, EventArgs e)
            //cancel testing
        {
            backgroundWorker.CancelAsync();
            swatch.Stop();
            timer.Stop();
            btnSaveTestResults.Enabled = false;
        }

        private void btnSaveTestResults_Click(object sender, EventArgs e)
            //save test results
        {
            SetProgressBarFile();
            CreateFileNames();
            WriteJSON(test);
            testProgress.PerformStep();
            testProgress.PerformStep();
        }

        private void SetProgressBarFile()
            //set up the progress bar for file saving
        {
            testProgress.Minimum = 0;
            testProgress.Maximum = 1;
            testProgress.Step = 1;
            testProgress.Value = 0;
        }

        private void dropdownTestType_SelectedIndexChanged(object sender, EventArgs e)
            //test type selection (random/file)
        {
            if (dropdownTestType.SelectedIndex == 0) //random
            {
                //disable load file button
                load_file.Enabled = false;

                //enable textboxes
                dropdownTestCount.Enabled = true;
                DisableTextboxes();
                EnableMinMaxUpDowns();
                EnableCheckBoxes();
                btnStartAlgorithmTests.Enabled = true;
                if (dropdownTestCount.SelectedIndex != null)
                {
                    DropdownEnableTextboxes(dropdownTestCount.SelectedIndex);
                }
            }
            else if (dropdownTestType.SelectedIndex == 1) //file
            {
                //enable file selection button
                load_file.Enabled = true;

                //disable textboxes
                dropdownTestCount.Enabled = false;
                DisableTextboxes();
                DisableMinMaxUpDowns();
                DisableCheckBoxes();
                btnStartAlgorithmTests.Enabled = false;
            }
        }

        private void dropdownTestCount_SelectedIndexChanged(object sender, EventArgs e)
            //test count (1-5)
        {
            DropdownEnableTextboxes(dropdownTestCount.SelectedIndex);
        }

        private void load_file_Click(object sender, EventArgs e)
            //load file and import data from file
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string array_file = openFileDialog1.FileName;
                string json = File.ReadAllText(array_file);
                _label_file_name.Text = array_file;
                test = new AlgorithmTests();
                test = JsonConvert.DeserializeObject<AlgorithmTests>(json);
                test.GetMainReference(this);
                FillUIElements();
                test.DisplayDataFromFile();
            }
        }

        private bool CheckCheckBoxes()
        {
            bool is_checked = false;

            foreach (CheckBox box in checkBoxes)
            {
                if (box.Checked == true)
                {
                    is_checked = true;
                }
            }

            return is_checked;
        }

        private bool CheckTextBoxes()
        {
            bool filled = true;

            foreach (NumericUpDown box in numericUpDowns)
            {
                if (box.Enabled == true && box.Text == "")
                {
                    filled = false;
                }
            }

            return filled;
        }

        private bool CheckTestCount()
        {
            bool is_selected = true;

            if (dropdownTestCount.Enabled == true
               && dropdownTestCount.SelectedItem == null)
            {
                is_selected = false;
            }

            return is_selected;
        }

        private void DropdownEnableTextboxes(int n)
        {
            foreach (NumericUpDown box in numericUpDowns)
            {
                box.Enabled = false;
            }
            for (int i = 0; i <= n; i++)
            {
                numericUpDowns[i].Enabled = true;
            }
        }

        private void DisableTextboxes()
        {
            foreach (NumericUpDown box in numericUpDowns)
            {
                box.Enabled = false;
            }
        }

        private void EnableMinMaxUpDowns()
        {
            foreach (NumericUpDown box in numericUpDownsMinMax)
            {
                box.Enabled = true;
            }
        }

        private void DisableMinMaxUpDowns()
        {
            foreach (NumericUpDown box in numericUpDownsMinMax)
            {
                box.Enabled = false;
            }
        }

        private void EnableCheckBoxes()
        {
            foreach (CheckBox box in checkBoxes)
            {
                box.Enabled = true;
            }
        }

        private void DisableCheckBoxes()
        {
            foreach (CheckBox box in checkBoxes)
            {
                box.Enabled = false;
            }
        }

        private void btnClearChart_Click(object sender, EventArgs e)
            //clear everything from charts
        {
            ClearCharts();
            btnStartAlgorithmTests.Enabled = true;
            btnSaveTestResults.Enabled = false;
            btnClearChart.Enabled = false;
            chartSeriesOrdinal = 0;
        }

        public void ClearCharts()
        {
            foreach (var series in barChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in lineChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void GetDataFromUI()
            //fetch values from UI controls and
            //store them into variables
        {
            algorithms[0] = cbAlgorithmBubbleSort.Checked;
            algorithms[1] = cbAlgorithmHeapSort.Checked;
            algorithms[2] = cbAlgorithmInsertionSort.Checked;
            algorithms[3] = cbAlgorithmMergeSort.Checked;
            algorithms[4] = cbAlgorithmQuickSort.Checked;
            algorithms[5] = cbAlgorithmSelectSort.Checked;
            n_rep = dropdownTestCount.SelectedIndex + 1;
            array_size[0] = (int)tbTest1.Value;
            array_size[1] = (int)tbTest2.Value;
            array_size[2] = (int)tbTest3.Value;
            array_size[3] = (int)tbTest4.Value;
            array_size[4] = (int)tbTest5.Value;
            min = (int)tbMinValue.Value;
            max = (int)tbMaxValue.Value;
        }

        private void CreateFileNames()
        {
            newFileName = "C:\\testresults\\test_" + DateTime.Now.ToString("ddMMyy_HHmmss");
            newJsonFileName = newFileName + ".json";
            newArrayFileName = newFileName + ".txt";
        }

        private void WriteJSON(AlgorithmTests test)
            //write JSON file with object data
        {
            saveFileDialog.FileName = newJsonFileName;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string json = JsonConvert.SerializeObject(test);
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter writeDataToFile = new StreamWriter(saveFileDialog.OpenFile());
                writeDataToFile.Write(json);
                writeDataToFile.Close();
            }
        }

        //private void WriteArrays(AlgorithmTests test)
        //{
        //    System.IO.File.WriteAllLines(newArrayFileName, test.array.Select(i=>i.ToString()));
        //}

        private void FillUIElements()
            //fill UI controls with data from imported object
        {
            cbAlgorithmBubbleSort.Checked = test.algorithms[0];
            cbAlgorithmHeapSort.Checked = test.algorithms[1];
            cbAlgorithmInsertionSort.Checked = test.algorithms[2];
            cbAlgorithmMergeSort.Checked = test.algorithms[3];
            cbAlgorithmQuickSort.Checked = test.algorithms[4];
            cbAlgorithmSelectSort.Checked = test.algorithms[5];
            dropdownTestCount.SelectedIndex = test.n_rep - 1;
            tbTest1.Value = test.array_size[0];
            tbTest2.Value = test.array_size[1];
            tbTest3.Value = test.array_size[2];
            tbTest4.Value = test.array_size[3];
            tbTest5.Value = test.array_size[4];
            tbMaxValue.Value = test.max;
            tbMinValue.Value = test.min;
            DisableTextboxes();
        }

        public void SetProgressBar()
        {
            testProgress.Minimum = 0;
            testProgress.Maximum = (algorithms.Where(c => c).Count()) * n_rep;
            testProgress.Step = 1;
            testProgress.Value = 0;
        }

        public void DisplayDataToGraph(string series, int x, double y)
        {
            barChart.Series[series].Points.AddXY(x + 1, y);
            lineChart.Series[series].Points.AddXY(array_size[test.test_ordinal], y);
        }

        public void DisplayDataToGraphFromFile(string series, int x, double y)
        {
            if (y != 0)
            {
                barChart.Series[series].Points.AddXY(x + 1, y);
                lineChart.Series[series].Points.AddXY(array_size[x], y);
            }
        }
    }
}

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

namespace SortingAlgorithmTests
{
    public partial class MainUI : Form
    {
        private NumericUpDown[] numericUpDowns;
        private NumericUpDown[] numericUpDownsMinMax;
        public bool[] algorithms = new bool[6];
        public int testRepetitions, min, max;
        int[] array_size = new int[5];
        string newJsonFileName;
        AlgorithmTests test;
        public GraphForm graphForm;
        public Stopwatch swatch;
        public int chartSeriesOrdinal = 0;

        public MainUI()
        {
            InitializeComponent();

            numericUpDowns = new NumericUpDown[] { tbTest1, tbTest2, tbTest3, tbTest4, tbTest5 };
            numericUpDownsMinMax = new NumericUpDown[] { tbMinValue, tbMaxValue };
            this.Text = "Aplikacija za testiranje algoritama sortiranja";
            _label_file_name.Text = "Ime datoteke";
            AlgorithmTests test = new AlgorithmTests();
            InitializeBackgroundWorkerHandlers();
        }

        //"start test" button funcitonality
        public void btnStartAlgorithmTests_Click(object sender, EventArgs e)
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

            else if (lbAlgs.Items.Count == 0 && dropdownTestType.SelectedIndex == 0)
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
                    test = new AlgorithmTests(algorithms, testRepetitions, array_size, min, max);
                    test.GetMainReference(this);
                    newJsonFileName = "test_" + DateTime.Now.ToString("ddMMyy_HHmmss") + ".json";
                }
                btnStartAlgorithmTests.Enabled = false;
                btnStopTesting.Enabled = true;
                InitializeGraphForm();
                graphForm.EnableChartSeries();
                SetTimer();
                RunAlgorithmTests();
            }
        }

        //start a timer to time the entire test
        private void SetTimer()
        {
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            swatch = new Stopwatch();
            swatch.Start();
        }

        //timer event to display time
        private void TimerTick(object sender, EventArgs e)
        {
            this.Text = "Proteklo vrijeme: "
                + swatch.Elapsed.Hours.ToString() + ":"
                + swatch.Elapsed.Minutes.ToString() + ":"
                + swatch.Elapsed.Seconds.ToString();
        }

        //background worker to do the testing
        private void RunAlgorithmTests()
        {
            backgroundWorker.RunWorkerAsync();
        }

        //background worker initialization
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
                btnStopTesting.Enabled = false;
                btnSaveTestResults.Enabled = true;
                btnStartAlgorithmTests.Enabled = true;
            };
        }

        //show this message on successful test complete
        private void ShowCompleteMessage()
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

        //cancel testing
        private void btnStopTesting_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
            swatch.Stop();
            timer.Stop();
            btnSaveTestResults.Enabled = false;
        }

        //save test results
        private void btnSaveTestResults_Click(object sender, EventArgs e)
        {
            SetProgressBarFile();
            WriteJSON(test);
            testProgress.PerformStep();
            testProgress.PerformStep();
        }

        //set up the progress bar for file saving
        private void SetProgressBarFile()
        {
            testProgress.Minimum = 0;
            testProgress.Maximum = 1;
            testProgress.Step = 1;
            testProgress.Value = 0;
        }

        //test type selection (random/file)
        private void dropdownTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownTestType.SelectedIndex == 0) //random
            {
                //disable load file button
                load_file.Enabled = false;

                //enable textboxes
                dropdownTestCount.Enabled = true;
                DisableTextboxes();
                EnableMinMaxUpDowns();
                EnableAlgorithmSelection();
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
                DisableAlgorithmSelection();
                btnStartAlgorithmTests.Enabled = false;
            }
        }

        //test count (1-5)
        private void dropdownTestCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropdownEnableTextboxes(dropdownTestCount.SelectedIndex);
        }

        //load file and import data from file
        private void load_file_Click(object sender, EventArgs e)
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

        //check if at least 1 textbox is not empty
        private bool CheckTextBoxes()
        {
            bool filled = true;

            foreach (NumericUpDown box in numericUpDowns)
            {
                if (box.Enabled == true && box.Text == "0")
                {
                    filled = false;
                }
            }

            return filled;
        }

        //check if test count is not 0
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

        //enable textboxes depending on test count
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

        //disable textboxes
        private void DisableTextboxes()
        {
            foreach (NumericUpDown box in numericUpDowns)
            {
                box.Enabled = false;
            }
        }

        //enable min and max array size textboxes
        private void EnableMinMaxUpDowns()
        {
            foreach (NumericUpDown box in numericUpDownsMinMax)
            {
                box.Enabled = true;
            }
        }

        //disable min and max array size textboxes
        private void DisableMinMaxUpDowns()
        {
            foreach (NumericUpDown box in numericUpDownsMinMax)
            {
                box.Enabled = false;
            }
        }

        //enable checkboxes
        private void EnableAlgorithmSelection()
        {
            lbAlgs.Enabled = true;
            clbAlgorithms.Enabled = true;
            btnAddRemoveAlgs.Enabled = true;
        }

        //disable checkboxes
        private void DisableAlgorithmSelection()
        {
            lbAlgs.Enabled = false;
            clbAlgorithms.Enabled = false;
            btnAddRemoveAlgs.Enabled = false;
        }

        //fetch values from UI controls and
        //store them into variables
        private void GetDataFromUI()
        {
            testRepetitions = dropdownTestCount.SelectedIndex + 1;
            array_size[0] = (int)tbTest1.Value;
            array_size[1] = (int)tbTest2.Value;
            array_size[2] = (int)tbTest3.Value;
            array_size[3] = (int)tbTest4.Value;
            array_size[4] = (int)tbTest5.Value;
            min = (int)tbMinValue.Value;
            max = (int)tbMaxValue.Value;
        }

        //write JSON file with object data
        private void WriteJSON(AlgorithmTests test)
        {
            saveFileDialog.FileName = newJsonFileName;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(test);
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextWriter writeDataToFile = new StreamWriter(saveFileDialog.OpenFile());
                writeDataToFile.Write(json);
                writeDataToFile.Close();
            }
        }

        //fill UI controls with data from imported object
        private void FillUIElements()
        {
            dropdownTestCount.SelectedIndex = test.n_rep - 1;
            tbTest1.Value = test.array_size[0];
            tbTest2.Value = test.array_size[1];
            tbTest3.Value = test.array_size[2];
            tbTest4.Value = test.array_size[3];
            tbTest5.Value = test.array_size[4];
            tbMaxValue.Value = test.max;
            tbMinValue.Value = test.min;
            DisableTextboxes();
            lbAlgs.Items.Clear();
            if (test.algorithms[0])
            {
                lbAlgs.Items.Add("Bubble sort");
                clbAlgorithms.SetItemChecked(0, true);
            }
            if (test.algorithms[1])
            {
                lbAlgs.Items.Add("Heap sort");
                clbAlgorithms.SetItemChecked(1, true);
            }
            if (test.algorithms[2])
            {
                lbAlgs.Items.Add("Insertion sort");
                clbAlgorithms.SetItemChecked(2, true);
            }
            if (test.algorithms[3])
            {
                lbAlgs.Items.Add("Merge sort");
                clbAlgorithms.SetItemChecked(3, true);
            }
            if (test.algorithms[4])
            {
                lbAlgs.Items.Add("Quick sort");
                clbAlgorithms.SetItemChecked(4, true);
            }
            if (test.algorithms[5])
            {
                lbAlgs.Items.Add("Selection sort");
                clbAlgorithms.SetItemChecked(5, true);
            }
        }

        private void clbAlgorithmsChecked()
        {
            lbAlgs.Items.Clear();
            for (int i = 0; i <= clbAlgorithms.Items.Count-1; i++)
            {
                if (clbAlgorithms.GetItemChecked(i))
                {
                    algorithms[i] = true;
                    lbAlgs.Items.Add(clbAlgorithms.Items[i].ToString());
                }
                else
                {
                    algorithms[i] = false;
                }
            }
        }

        private void btnAddRemoveAlgs_Click(object sender, EventArgs e)
        {
            clbAlgorithmsChecked();
        }

        //set up progress bar on UI
        public void SetProgressBar()
        {
            testProgress.Minimum = 0;
            testProgress.Maximum = (algorithms.Where(c => c).Count()) * testRepetitions;
            testProgress.Step = 1;
            testProgress.Value = 0;
        }

        public void InitializeGraphForm()
        {
            graphForm = new GraphForm(test);
            graphForm.Show();
            graphForm.EnableChartSeries();
            Thread.Sleep(1000);
        }
    }
}

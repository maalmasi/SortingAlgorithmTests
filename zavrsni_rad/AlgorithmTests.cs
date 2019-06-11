using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace zavrsni_rad
{
    public class AlgorithmTests
    {
        public int[] array, array_copy;
        public int[] array_size;
        public int n_rep, min, max, test_ordinal, counter;
        public bool[] algorithms;
        public double[] timeBubble, timeHeap, timeInsertion, timeMerge, timeQuick, timeSelection;
        MainUI main;
        public bool complete;

        Stopwatch swatch = new Stopwatch();
        Random rand = new Random();

        public AlgorithmTests() { }

        public AlgorithmTests(bool[] _algorithms, int _n_rep, int[] _array_size, int _min, int _max)
        {
            algorithms = new bool[6];
            array_size = new int[5];
            timeBubble = new double[5];
            timeHeap = new double[5];
            timeInsertion = new double[5];
            timeMerge = new double[5];
            timeQuick = new double[5];
            timeSelection = new double[5];
            algorithms = _algorithms;
            array_size = _array_size;
            n_rep = _n_rep;
            min = _min;
            max = _max;
            counter = 0;
            test_ordinal = 0;
            complete = true;
        }

        public void GetMainReference(MainUI mainui)
        {
            main = mainui;
        }

        public void RunTests()
        {
            main.SetProgressBar();
            while (test_ordinal < n_rep && !main.backgroundWorker.CancellationPending)
            {
                CreateArray();

                if(algorithms[0] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.BubbleSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeBubble[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Bubble", main.chartSeriesOrdinal, timeBubble[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[1] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.HeapSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeHeap[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Heap", main.chartSeriesOrdinal, timeHeap[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[2] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.InsertionSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeInsertion[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Insertion", main.chartSeriesOrdinal, timeInsertion[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[3] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.MergeSort(array_copy, 0, array_size[test_ordinal] - 1);
                    swatch.Stop();
                    timeMerge[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Merge", main.chartSeriesOrdinal, timeMerge[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[4] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.QuickSort(array_copy, 0, array_size[test_ordinal] - 1);
                    swatch.Stop();
                    timeQuick[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Quick", main.chartSeriesOrdinal, timeQuick[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[5] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    Algorithms.SelectionSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeSelection[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.DisplayDataToGraph("Selection", main.chartSeriesOrdinal, timeSelection[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                test_ordinal++;
                main.chartSeriesOrdinal++;
                if (main.backgroundWorker.CancellationPending)
                {
                    main.testProgress.Value = main.testProgress.Maximum;
                    main.btnClearChart.Enabled = true;
                    main.btnStopTesting.Enabled = false;
                    main.btnSaveTestResults.Enabled = false;
                    complete = false;
                    main.swatch.Stop();
                    main.timer.Stop();
                    ShowCancelledMessage();
                    break;
                }
            }
        }

        private void ShowCancelledMessage()
        {
            string message = "Test zaustavljen nakon: "
                        + swatch.Elapsed.Hours.ToString() + ":"
                        + swatch.Elapsed.Minutes.ToString() + ":"
                        + swatch.Elapsed.Seconds.ToString();
            string title = "Test zaustavljen!";
            main.Text = "Aplikacija za testiranje algoritama sortiranja";
            MessageBox.Show(message, title);
        }

        public void DisplayDataFromFile()
        {
            for (int i = 0; i < n_rep; i++)
            {
                main.DisplayDataToGraphFromFile("Bubble", main.chartSeriesOrdinal, timeBubble[i]);
                main.DisplayDataToGraphFromFile("Heap", main.chartSeriesOrdinal, timeHeap[i]);
                main.DisplayDataToGraphFromFile("Insertion", main.chartSeriesOrdinal, timeInsertion[i]);
                main.DisplayDataToGraphFromFile("Merge", main.chartSeriesOrdinal, timeMerge[i]);
                main.DisplayDataToGraphFromFile("Quick", main.chartSeriesOrdinal, timeQuick[i]);
                main.DisplayDataToGraphFromFile("Selection", main.chartSeriesOrdinal, timeSelection[i]);
                main.chartSeriesOrdinal++;
                main.btnClearChart.Enabled = true;
            }
        }

        public void CreateArray()
        {
            array = new int[array_size[test_ordinal]];
            array_copy = new int[array_size[test_ordinal]];
            for (int i = 0; i < array_size[test_ordinal]; i++)
            {
                array[i] = rand.Next(min, max);
            }
        }

        public bool ShouldSerializearray()
        {
            return false;
        }
        public bool ShouldSerializearray_copy()
        {
            return false;
        }
        public bool ShouldSerializemain()
        {
            return false;
        }
        public bool ShouldSerializecounter()
        {
            return false;
        }
        public bool ShouldSerializetest_ordinal()
        {
            return false;
        }
    }
}

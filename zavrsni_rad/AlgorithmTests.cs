using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SortingAlgorithmTests
{
    public class AlgorithmTests
    {
        public int[] array, array_copy;
        public int[] array_size;
        public int n_rep, min, max, test_ordinal;
        public bool[] algorithms;
        public double[] timeBubble, timeHeap, timeInsertion, timeMerge, timeQuick, timeSelection;
        public float[] comparisonCounterBubble, comparisonCounterHeap, comparisonCounterInsertion, comparisonCounterMerge, comparisonCounterQuick, comparisonCounterSelection;
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
            comparisonCounterBubble = new float[5];
            comparisonCounterHeap = new float[5];
            comparisonCounterInsertion = new float[5];
            comparisonCounterMerge = new float[5];
            comparisonCounterQuick = new float[5];
            comparisonCounterSelection = new float[5];
            algorithms = _algorithms;
            array_size = _array_size;
            n_rep = _n_rep;
            min = _min;
            max = _max;
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
                    comparisonCounterBubble[test_ordinal] = Algorithms.BubbleSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeBubble[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Bubble", test_ordinal, timeBubble[test_ordinal], array_size[test_ordinal], comparisonCounterBubble[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[1] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    comparisonCounterHeap[test_ordinal] = Algorithms.HeapSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeHeap[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Heap", test_ordinal, timeHeap[test_ordinal], array_size[test_ordinal], comparisonCounterHeap[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[2] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    comparisonCounterInsertion[test_ordinal] = Algorithms.InsertionSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeInsertion[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Insertion", test_ordinal, timeInsertion[test_ordinal], array_size[test_ordinal], comparisonCounterInsertion[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[3] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    comparisonCounterMerge[test_ordinal] = Algorithms.MergeSort(array_copy, 0, array_size[test_ordinal] - 1);
                    swatch.Stop();
                    timeMerge[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Merge", test_ordinal, timeMerge[test_ordinal], array_size[test_ordinal], comparisonCounterMerge[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[4] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    comparisonCounterQuick[test_ordinal] = Algorithms.QuickSort(array_copy, 0, array_size[test_ordinal] - 1);
                    swatch.Stop();
                    timeQuick[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Quick", test_ordinal, timeQuick[test_ordinal], array_size[test_ordinal], comparisonCounterQuick[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                if(algorithms[5] && !main.backgroundWorker.CancellationPending)
                {
                    array_copy = (int[])array.Clone();
                    swatch.Reset();
                    swatch.Start();
                    comparisonCounterSelection[test_ordinal] = Algorithms.SelectionSort(array_copy, array_size[test_ordinal]);
                    swatch.Stop();
                    timeSelection[test_ordinal] = swatch.Elapsed.TotalSeconds;
                    main.graphForm.DisplayDataToGraph("Selection", test_ordinal, timeSelection[test_ordinal], array_size[test_ordinal], comparisonCounterSelection[test_ordinal]);
                    main.testProgress.PerformStep();
                    Thread.Sleep(100);
                }
                test_ordinal++;
                main.chartSeriesOrdinal++;
                if (main.backgroundWorker.CancellationPending)
                {
                    main.testProgress.Value = main.testProgress.Maximum;
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

        public void ShowCancelledMessage()
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
            main.InitializeGraphForm();
            for (int i = 0; i < n_rep; i++)
            {
                main.graphForm.DisplayDataToGraphFromFile("Bubble", i, timeBubble[i], array_size[i], comparisonCounterBubble[i]);
                main.graphForm.DisplayDataToGraphFromFile("Heap", i, timeHeap[i], array_size[i], comparisonCounterHeap[i]);
                main.graphForm.DisplayDataToGraphFromFile("Insertion", i, timeInsertion[i], array_size[i], comparisonCounterInsertion[i]);
                main.graphForm.DisplayDataToGraphFromFile("Merge", i, timeMerge[i], array_size[i], comparisonCounterMerge[i]);
                main.graphForm.DisplayDataToGraphFromFile("Quick", i, timeQuick[i], array_size[i], comparisonCounterQuick[i]);
                main.graphForm.DisplayDataToGraphFromFile("Selection", i, timeSelection[i], array_size[i], comparisonCounterSelection[i]);
                main.chartSeriesOrdinal++;
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
        public bool ShouldSerializetest_ordinal()
        {
            return false;
        }
        public bool ShouldSerializecomplete()
        {
            return false;
        }
    }
}

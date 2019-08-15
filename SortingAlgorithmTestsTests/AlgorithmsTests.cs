using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithmTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests.Tests
{
    [TestClass()]
    public class AlgorithmsTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.BubbleSort(array, 10);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.HeapSort(array, 10);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.InsertionSort(array, 10);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.MergeSort(array, 0, 9);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.QuickSort(array, 0, 9);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            int[] array = new int[10] { 7, 2, 19, 1, -62, 643, 234, 5, -121, -2 };
            Algorithms.SelectionSort(array, 10);
            for (int i = 0; i < 9; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Assert.Fail("Array not sorted");
                }
            }
        }
    }
}
using System;

namespace SortingAlgorithmTests
{
    public static class Algorithms
    {
        public static float BubbleSort(int[] arr, int n)
        {
            float count = 0;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    count++;
                }
            return count;
        }

        public static float HeapSort(int[] arr, int n)
        {
            float count = 0;
            for (int i = n / 2 - 1; i >= 0; i--)
                count += Heapify(arr, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                count += Heapify(arr, i, 0);
            }
            return count;
        }
        static float Heapify(int[] arr, int n, int i)
        {
            float count = 0;
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest])
                largest = l;
            count++;

            if (r < n && arr[r] > arr[largest])
                largest = r;
            count++;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                count += Heapify(arr, n, largest);
            }
            count++;

            return count;
        }

        public static float InsertionSort(int[] arr, int n)
        {
            float count = 0;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    count++;
                }
                arr[j + 1] = key;
            }
            return count;
        }

        public static float MergeSort(int[] arr, int p, int r)
        {
            float count = 0;
            if (p < r)
            {
                int q = (p + r) / 2;
                count += MergeSort(arr, p, q);
                count += MergeSort(arr, q + 1, r);
                count += Merge(arr, p, q, r);
            }
            return count;
        }

        static float Merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            float count = 0;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
                count++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
            return count;
        }

        public static float QuickSort(int[] arr, int low, int high)
        {
            float count = 0;
            if (low < high)
            {
                var result = Partition(arr, low, high);
                int pi = result.Item1;
                count += result.Item2;
                count += QuickSort(arr, low, pi - 1);
                count += QuickSort(arr, pi + 1, high);
            }
            return count;
        }
        static Tuple<int, float> Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
                float count = 0;

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                count++;
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return Tuple.Create(i + 1, count);
        }

        public static float SelectionSort(int[] arr, int n)
        {
            float count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                    count++;
                }
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return count;
        }
    }
}

//using System;

//namespace Algorithms
//{
//    class QuickSort
//    {
        
//        public int Partition(int[] A, int l, int h)
//        {
//            int temp;
//            int pivot = A[l];
//            int i = l;int j = h;
//            do
//            {
//                do { i++; } while (pivot >= A[i]);
//                do { j--; } while (A[j] > pivot);
//                if (i < j) {
//                    temp = A[j];
//                    A[j] = A[i];
//                    A[i] = temp;
//                }
//            } while (i < j);
//            temp = A[j];
//            A[j] = A[l];
//            A[l] = temp;

//            return j;
//        }
//        public int[] Sort(int[] A, int l, int h)
//        {
//            int j;
//            if (l < h) {
//                j = Partition(A, l, h);
//                Sort(A, l, j);
//                Sort(A, j + 1, h);
//            }

//            return A;

//        }
//        static void Main(string[] args)
//        {
//            QuickSort q = new QuickSort();
//            int[] sortedArr;
//            int[] arr = { 5, 7, 6, 1, 3,Int32.MaxValue };
//            Console.WriteLine("Quick Sort");
//            sortedArr =  q.Sort(arr, 0, arr.Length - 1);

//            for (int i = 0; i < arr.Length-1; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

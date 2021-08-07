//using System;

//namespace Algorithms
//{
//    class MergeSort
//    {
        
//        public int[] Merge(int[] arr, int p, int q, int r)
//        {
//            int[] L = new int[q+1];
//            int[] M = new int[r-q];
//            int[] sortedArray = new int[arr.Length];
//            int k = 0;
//            for (int  i = p;  i <=q;  i++)
//            {
//                L[i] = arr[i];
//            }
//            for (int i = q+1; i <= r; i++)
//            {
//                M[k] = arr[i];
//                k++;
//            }
//            int a = 0;
//            int b = 0;
//            int c = 0;
//            while (a <= L.Length-1 &&  b <= M.Length -1)
//            {
//                if (L[a] < M[b])
//                {
//                    sortedArray[c] = L[a];
//                    a++;
//                }
//                else
//                {
//                    sortedArray[c] = M[b];
//                    b++;
//                }

//                c++;
//            }
//            for (int i = a; i <= L.Length -1; i++)
//            {
//                sortedArray[c] = L[i];
//                c++;
//            }
//            for (int i = b; i <= M.Length - 1; i++)
//            {
//                sortedArray[c] = M[i];
//                c++;
//            }

//            return sortedArray;
//        }
       
//        static void Main(string[] args)
//        {
//            MergeSort q = new MergeSort();
//            int[] sortedArr;
//            int[] arr = { 5, 6, 7, 1, 3 };
//            Console.WriteLine("Merge Sort");

//            sortedArr =  q.Merge(arr,0,2, arr.Length - 1);

//            for (int i = 0; i <= sortedArr.Length-1; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

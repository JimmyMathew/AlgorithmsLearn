//using System;

//namespace Algorithms
//{
//    class ShellSort
//    {
//        public int[] Shell(int[] arr)
//        {
//            int n = arr.Length;

//            for (int gap = n/2; gap > 0; gap/=2)
//            {
//                for (int i = gap; i < n; i++)
//                {
//                    int j = i - gap;
//                    int x = arr[i];

//                    while (j > -1 && arr[j] > x)
//                    {
//                        arr[j + gap] = arr[j];
//                        j=j-gap;
//                    }
//                    arr[j + gap] = x;
//                }
//            }
            
//            return arr;
//        }
//        static void Main(string[] args)
//        {
//            ShellSort q = new ShellSort();
//            int[] sortedArr;
//            int[] arr = { 436, 232, 201, 86, 32, 63, 104 };
//            Console.WriteLine("Shell Sort");

//            sortedArr = q.Shell(arr);

//            for (int i = 0; i < sortedArr.Length; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

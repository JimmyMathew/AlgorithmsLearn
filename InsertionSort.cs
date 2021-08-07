//using System;

//namespace Algorithms
//{
//    class InsertionSort
//    {
//        static void Main(string[] args)
//        {

//            int[] arr = { 7, 6, 5, 1, 3 };
//            Console.WriteLine("Insertion Sort");
//            for (int i = 1; i < arr.Length; i++)
//            {
//                int x, j;
//                x = arr[i];
//                j = i - 1;
//                while (j > -1 && arr[j] > x)
//                {
//                    arr[j + 1] = arr[j];
//                    j--;

//                }
//                arr[j + 1] = x;

//            }

//            for (int i = 0; i <= arr.Length - 1; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

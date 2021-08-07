//using System;

//namespace Algorithms
//{
//    class SelectionSort
//    {
//        static void Main(string[] args)
//        {
            
//            int[] arr = { 5, 7, 6, 1, 3 }; 
//            Console.WriteLine("Selection Sort");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int k, j,temp;
//                for (j=k=i;  j < arr.Length; j++)
//                {
//                    if (arr[j] < arr[k])
//                        k = j;
//                }
//                temp = arr[k];
//                arr[k] = arr[i];
//                arr[i] = temp;
//            }

//            for (int i = 0; i <= arr.Length-1; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

//using System;

//namespace Algorithms
//{
//    class BubbleSort
//    {
//        public int[] Bubble(int[] arr)
//        {
//            for (int i = 0; i < arr.Length-1; i++)
//            {
//                for (int j = 0; j < arr.Length-1-i; j++)
//                {
//                    int temp;
//                    if (arr[j] > arr[j + 1])
//                    {
//                        temp = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = temp;
//                    }
//                }
//            }
//            return arr;
//        }
//        static void Main(string[] args)
//        {
//            BubbleSort obj = new BubbleSort();
//            int[] arr = { 5, 7, 6, 1, 3 };
//            Console.WriteLine("Bubble Sort");
//            int[] sortedArr = obj.Bubble(arr);
//            for (int i = 0; i <= sortedArr.Length-1; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

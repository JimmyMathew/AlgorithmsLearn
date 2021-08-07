//using System;

//namespace Algorithms
//{
//    class CountingSort
//    {
        
//        public int[] Counting(int[] arr)
//        {
//            int max = 0;
//            int[] outputArr = new int[arr.Length];
//            for (int i = 0; i <= arr.Length-1; i++)
//            {
//                if (arr[i] > max)
//                    max = arr[i];
//            }
//            int[] countArr = new int[max + 1];
           
//            for (int i = 0; i <= arr.Length - 1; i++)
//            {
//                countArr[arr[i]] += 1 ;
//            }
//            for (int i = 1; i <= countArr.Length - 1; i++)
//            {
//                countArr[i] = countArr[i] + countArr[i - 1];
//            }
//            for (int i = 0; i <= arr.Length - 1; i++)
//            {
//                outputArr[countArr[arr[i]] - 1] = arr[i];
//                countArr[arr[i]] --;
//            }
//            return outputArr;
//        }
       
//        static void Main(string[] args)
//        {
//            CountingSort q = new CountingSort();
//            int[] sortedArr;
//            int[] arr = { 4,2,2,8,3,3,1};
//            Console.WriteLine("Counting Sort");

//            sortedArr =  q.Counting(arr);

//            for (int i = 0; i <= sortedArr.Length-1; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

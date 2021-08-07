//using System;
//using System.Collections.Generic;

//namespace Algorithms
//{
//    class BucketSort
//    {
        
//        public int[] Bucket(int[] arr)
//        {
//            int max = 0;
//            //Create a final array which is equal to the length of the given array. 
//            int[] outputArr = new int[arr.Length];
//            //Find the max element
//            for (int i = 0; i <= arr.Length-1; i++)
//            {
//                if (arr[i] > max)
//                    max = arr[i];
//            }
//            //Create a bucket of the size of max element + 1 
//            List<int>[] bucketArr = new List<int>[max + 1];

//            //Initialize a Linked list in each space of the array
//            for (int i = 0; i < bucketArr.Length; i++)
//            {
//                List<int> bucketList = new List<int>();
//                bucketArr[i] = bucketList;
//            }
//           //Place the elements in the Linked list of the bucket 
//            for (int i = 0; i < arr.Length ; i++)
//            {
//                bucketArr[arr[i]].Add(arr[i]);
//            }

//            //Place the elements from each linked list to output array
//            //Keep track of the array space with the below variable. Increment correctly
//            int o = 0;
//            for (int i = 0; i < bucketArr.Length; i++)
//            {
//                for (int j = 0; j < bucketArr[i].Count; j++)
//                {

//                    outputArr[o] = bucketArr[i][j];
//                    o++;
//                }
                
//            }
//            return outputArr;
//        }
       
//        static void Main(string[] args)
//        {
//            BucketSort q = new BucketSort();
//            int[] sortedArr;
//            int[] arr = { 4,2,2,8,3,3,1};
//            Console.WriteLine("Bucket Sort");

//            sortedArr =  q.Bucket(arr);

//            for (int i = 0; i <= sortedArr.Length-1; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

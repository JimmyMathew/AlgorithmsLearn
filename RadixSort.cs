//using System;
//using System.Collections.Generic;

//namespace Algorithms
//{
//    class RadixSort
//    {
        
//        public int[] Radix(int[] arr)
//        {
//            int max = 0;
//            int pass = 0;
//            int radix = 1;

//            //Final output array of the given array length
//            int[] outputArr = new int[arr.Length];

//            //Assuming the numbers are of decimal system we declare a bucket of 10
//            List<int>[] bucketArr = new List<int>[10];

//            //Initialize a Linked list in each space of the bucket array
//            for (int i = 0; i < bucketArr.Length; i++)
//            {
//                bucketArr[i] = new List<int>(); ;
//            }

//            //To find the passes we need the max number
//            for (int i = 0; i <= arr.Length - 1; i++)
//            {
//                if (arr[i] > max)
//                    max = arr[i];
//            }
//            //Find the digits of the max number because based on the digits only we determine the number of passes. 
//            //Eg: if 237 means the passes would be 3 because of 3 digits.
//            while (max != 0)
//            {
//               max =  max / 10;
//                pass++;
//            }

//            //Place the elements in the Linked list of the bucket based on the digits of the number. 
//            //First take the last digit from the right and then second and so on..Eg: 237 means take 7 and place the 237 in bin 7 
//            //Index the next pass take the second . Eg: 237 means place the number in bin 3
//            for (int i = 1; i <= pass; i++)
//            {
                
//                if(i != 1)
//                radix = radix * 10;
//                for (int j = 0; j < arr.Length; j++)
//                {
//                    int position  = (arr[j] / radix) % 10;
//                    bucketArr[position].Add(arr[j]);
//                }
//                //Place the elements from each linked list to the same array
//                //Keep track of the array space with the below variable. Increment correctly
//                int o = 0;
//                for (int k = 0; k < bucketArr.Length; k++)
//                {
//                    for (int j = 0; j < bucketArr[k].Count; j++)
//                    {
//                        arr[o] = bucketArr[k][j];
//                        o++;
//                    }
//                    //initialize the bucket of linked list with new ones after takeing the elements out
//                    bucketArr[k] = new List<int>();
//                }
//            }
//            return arr;
//        }
       
//        static void Main(string[] args)
//        {
//            RadixSort q = new RadixSort();
//            int[] sortedArr;
//            int[] arr = { 436,232,201,86,32,63,104};
//            Console.WriteLine("Radix Sort");

//            sortedArr =  q.Radix(arr);

//            for (int i = 0; i < sortedArr.Length; i++)
//            {
//                Console.WriteLine(sortedArr[i]);
//            }
//            Console.Read();
//        }
//    }
//}

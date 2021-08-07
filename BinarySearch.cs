using System;

namespace Algorithms
{
    class BinarySearch
    {
        public int Binary(int[] arr, int target)
        {
            //Find the initial low, high elements
            int low = 0;
            int high = arr.Length - 1;
           //Until the low is getting bigger than high we need to repeat this
            while (low <= high)
            {
                //find the mid
                int mid = low + (high - low) / 2;
                //Find the new low and high based on conditions
                if (arr[mid] == target)
                    return mid;
                else if (target > arr[mid])
                    low = mid + 1;
                else if (target < arr[mid])
                    high = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {

            int[] arr = { 5,6,7,8,9,10 };
            int element = 6;
            Console.WriteLine("Binary Search");
            BinarySearch obj = new BinarySearch();
            int result = obj.Binary(arr, element);
            if (result == -1)
                Console.WriteLine(element + " is not available:");
            else
                Console.WriteLine(element + " is at position: " + result);
            Console.Read();
        }
    }
}

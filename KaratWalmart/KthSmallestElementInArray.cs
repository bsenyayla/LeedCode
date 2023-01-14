using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    /*
     K’th Smallest/Largest Element in Unsorted Array
     */
    internal class KthSmallestElementInArray
    {
        public KthSmallestElementInArray() {
            Console.WriteLine("K’th Smallest/Largest Element in Unsorted Array..");
            
            int[] nums = new int[] { 7, 10, 4, 3, 20, 15 ,4,7,20};
            
            int k = 4, timeCost = 0;
            int basicRes = FirstWay(nums, k, out timeCost);
            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}", k);
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
            Console.WriteLine("\n================================================================================");



            int[] numsS = new int[] { 7, 10, 4, 3, 20, 15, 4, 7, 20 };
            int secondRes = SecondWay(numsS, k, out timeCost);
            Console.WriteLine("SecondWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}", k);
            Console.WriteLine("Output: [" + String.Join(" , ", secondRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
            Console.WriteLine("\n================================================================================");


            int[] numsT = new int[] { 7, 10, 4 };
            int thirdRes = ThirdWay(numsT, k, out timeCost);
            Console.WriteLine("ThirdWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}", k);
            Console.WriteLine("Output: [" + String.Join(" , ", thirdRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
            Console.WriteLine("\n================================================================================");
        }

        //DataStructure
        public int ThirdWay(int[] nums, int k, out int timecomp)
        {
            DataStruct_SortAndOrderArray arr = new DataStruct_SortAndOrderArray(nums);
            

            timecomp = 0;
  

            return arr.KthSmallest(k); ;
        }

        //SortedSet 
        public int SecondWay(int[] nums, int k, out int timecomp)
        {
            int retVal = 0;
            timecomp = 0;
            SortedSet<int> srtArr = new SortedSet<int>(nums);

            retVal=srtArr.ElementAt(k - 1);

            return retVal;
        }

        public int FirstWay(int[] nums, int k, out int timecomp)
        {
            int retVal = 0;
            timecomp=0;

            nums = nums.Distinct().ToArray<int>();
            Array.Sort(nums);

            retVal = nums[k-1];

            timecomp++;
            return retVal;
        }
    }
}

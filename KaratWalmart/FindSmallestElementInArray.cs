using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KaratWalmart
{
    /*
     Find the kth smallest element in a given unsorted array.
     */
    public class FindSmallestElementInArray
    {
        public FindSmallestElementInArray() {
            Console.WriteLine("Q1-Find the two numbers from an array whose sum is equal to a given target number.");

            int[] nums = new int[] { 6, 9, 7, 3, 1, 8, 2, 4,45,2,67 };
            int  timeCost = 0;
            int basicRes = FirstWay(nums,  out timeCost);

            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");

            Console.WriteLine("=================================================================================");
            int timeCosts = 0;
            int secondRes = SecondWay(new int[] { 6, 9, 7, 3, 8, 1, 2, 4, 45, 2 }, out timeCosts);
            Console.WriteLine("SecondWay");
            Console.WriteLine("Input: [" + String.Join(" , ", new int[] { 6, 9, 7, 3, 1, 8, 2, 4, 45, 2 }) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", secondRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCosts) + "]");

           
            int fourthdWay = FourthdWay(new int[] { 6, 9, 7, 3, 8, 1, 2, 4, 45, 2 }, out timeCosts);
            Console.WriteLine("FourthdWay");
            Console.WriteLine("Input: [" + String.Join(" , ", new int[] { 6, 9, 7, 3, 1, 8, 2, 4, 45, 2 }) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", fourthdWay) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCosts) + "]");
        }



        public int FourthdWay(int[] nums, out int timeCost)
        {
            int min = 0;
            timeCost = 0;

            return nums.OrderBy(x => x).Take(1).SingleOrDefault();
        }

        public int ThirdWay(int[] nums, out int timeCost)
        {
            int min = 0;
            timeCost = 0;

            return nums.Min(); 
        }

        //linq nums.min()
        public int SecondWay(int[] nums, out int timeCost)
        {
            timeCost = 0;
            int tmp = 0, min = nums[0];
            int rep = nums.Length/2;
            
            if (nums.Length % 2 != 0) {
                rep = ((int)nums.Length / 2) + 1;
            }

            for (int i = 0, j = nums.Length-1; i < rep; i++, j--) {
                timeCost++;

                if (nums[i] > nums[j])
                {
                    tmp = nums[j];
                }
                else
                {
                    tmp = nums[i];
                }

                if (tmp < min) {
                    min = tmp;
                }
            }

            return min;
        }


        public int FirstWay(int[] nums, out int timeCost) {
            timeCost = 0;

            if (nums.Length == 0) return 0;
            timeCost ++;
            Array.Sort(nums);

            return nums[0];
        }

    }
}

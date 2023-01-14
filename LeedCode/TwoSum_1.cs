using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class TwoSum_1
    {
/*
         Given an array of integers nums and an integer target, 
return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution,
and you may not use the same element twice.
        You can return the answer in any order.
*/

        int count = 0;
        public TwoSum_1() {
            Console.WriteLine("<<== Two Sum 1 ============================================================================>>");


            int[] nums = new int[] { 3, 3 };
            int target = 6;

            //int[] rec = TwoSum(nums, target);
            //int[] rec = TwoSum_Sol1(nums, target);
            //int[] rec = TwoSum_Sol2(nums, target);
            int[] rec = TwoSum_Sol3(nums, target);


            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}",target);
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
            Console.WriteLine("tik:" + count);
        }
/*         [2,7,11,15]
        9
        [3,2,4]
        6
        [3,3]
        6
[0,1]
[1,2]
[0,1]                     */

        public int[] TwoSum_Sol3(int[] nums, int target) { 
            int left = 0;
            for (int i = 0; i < nums.Length - 1; i++) {
                left = target - nums[i];

                int res=Array.IndexOf(nums, left, i+1);
                if (res == -1) continue;

                return new int[] { i, res };

            }

            return new int[] { };
        }




        public int[] TwoSum_Sol2(int[] nums, int target) { //hash table ile
            Hashtable table = new Hashtable();

            int i = 0;
            while (i < nums.Length && table[nums[i]] == null) {
                table[target - nums[i]] = i;
                i++;
            }

            if (i < nums.Length) {
                return new int[] { (int)table[nums[i]], i };
            }

            return new int[] { };
        }

        public int[] TwoSum_Sol1(int[] nums, int target) { //hash table ile
            Hashtable table = new Hashtable();

            int i = 0;
            while (i < nums.Length && table[nums[i]]==null) {
                table[target - nums[i]] = i;
                i++;
            }

            if (i < nums.Length) {
                return new int[] { (int)table[nums[i]], i };
            }

            return new int[] { };
        }

        public int[] TwoSum(int[] nums, int target) {

            for (int i = 0; i < nums.Length; i++) {

                for (int j = i+1; j < nums.Length; j++) {

                    if (nums[i] + nums[j] == target) {

                        return new int[] { i,j};
                    }
                }


            }

            return new int[] { };

        }
    }
}

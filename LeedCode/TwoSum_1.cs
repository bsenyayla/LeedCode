using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class TwoSum_1
    {
        public TwoSum_1() {
            Console.WriteLine("<<== Two Sum 1 ============================================================================>>");


            int[] nums = new int[] { 3, 2, 4 };
            int target = 9;

            int[] rec = TwoSum(nums, target);


            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}",target);
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
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

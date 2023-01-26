using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    /*
     Find the single occurring element in an array, in which all other elements are occurring twice.
     */
    internal class FindSingleElemantAtTwiceRepatedArray
    {
        public FindSingleElemantAtTwiceRepatedArray()
        {
            Console.WriteLine("Q1-Find the single occurring element in an array, in which all other elements are occurring twice.");

            int[] nums = new int[] { 1, 2, 2, 2, 3, 4, 1 };
            int timeCost = 0;
            int[] basicRes = FirstWay(nums, out timeCost);

            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");


            Console.WriteLine("\n================================================================================");
            int[] secondRes = SecondWay(nums, out timeCost);
            Console.WriteLine("SecondWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", secondRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");


            Console.WriteLine("\n================================================================================");
            int[] thirdRes = ThirdWay(nums, out timeCost);
            Console.WriteLine("ThirdWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", thirdRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
        }

        /*
           timecomp++;
           indexNumber = Array.IndexOf(nums, left,i+1);
         */

        public int[] ThirdWay(int[] nums, out int timeCost)
        {
            List<int> retVal = new List<int>();

            timeCost = 0;
            int[] disArr = nums.Distinct().ToArray();

            foreach (int rc in disArr)
            {
                timeCost++;

                int tmpRe = Array.IndexOf(nums, rc, 0);
                tmpRe = Array.IndexOf(nums, rc, tmpRe + 1);

                if (tmpRe == -1)
                {
                    retVal.Add(rc);
                }
                continue;
            }

            
            return retVal.ToArray();
        }

        public int[] SecondWay(int[] nums, out int timeCost)
        {
            List<int> retVal = new List<int>();
            timeCost = 0;
            int count = 0;
            int previous = nums[0];


            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                timeCost++;

                if (previous != nums[i])
                {
                    if (count == 0)
                    {
                        retVal.Add(previous);
                    }
                    count = 0;
                }

                if (previous == nums[i])
                {
                    count++;
                }

                previous = nums[i];
            }

            if (count == 0)
            {
                retVal.Add(previous);
            }




            return retVal.ToArray<int>();

            //int[] sd = nums.OrderBy(x => x).ToArray<int>();
        }


        public int[] FirstWay(int[] nums, out int timeCost)
        {
            int min = 0;
            timeCost = 0;

            int[] fsd = nums.GroupBy(x => x).Where(x => x.Count() < 2).Select(x => x.Key).ToArray();

            IEnumerable<int> result = from a in nums
                                      group a by a
                                      into gg
                                      where gg.Count() < 2
                                      select gg.Key;

            int[] ff = result.ToArray<int>();

            return ff;
        }
    }
}
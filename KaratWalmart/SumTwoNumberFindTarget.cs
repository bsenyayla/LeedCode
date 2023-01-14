using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    //Find the two numbers from an array whose sum is equal to a given target number.
    public class SumTwoNumberFindTarget
    {
        public SumTwoNumberFindTarget()
        {

            Console.WriteLine("Q1-Find the two numbers from an array whose sum is equal to a given target number.");

            int[] nums = new int[] { 1,9,7,3,1,8,2,4 };
            int target = 6,timeCost=0;
            int[] basicRes= BasicWay(nums, target, out timeCost);
            Console.WriteLine("BasicWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "] , k={0}", target);
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
 
            //OptimumWay(nums, target);
            //BestWay(nums, target);
            //TwoSum_Sol1(nums, target);
        }


        public int[] TwoSum_Sol1(int[] nums, int target, out int timecomp)
        { //hash table ile
            Hashtable table = new Hashtable();
             timecomp = 0;
            int i = 0;
            while (i < nums.Length && table[nums[i]] == null)
            {
                table[target - nums[i]] = i;
                timecomp++;

                i++;
            }

            if (i < nums.Length)
            {
                //Console.WriteLine("Hash Time:" + timecomp);
                return new int[] { (int)table[nums[i]], i };
            }

            return new int[] { };
        }

        public int[] BestWay(int[] nums, int target, out int timecomp)
        {
            int left = 0;
            timecomp = 0;
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++) {
                left = target - nums[i];
                timecomp++;
                if (ht[nums[i]] == null)
                {
                    ht[left] = i;
                }
                else
                {

                    int indexNo = Convert.ToInt16(ht[nums[i]]);

                    //Console.WriteLine("bir:[" +indexNo + "]:" + nums[indexNo]);
                    //Console.WriteLine("iki:[" + i + "]:" + nums[i]);
                    //Console.WriteLine("Best Time:" + timecomp);

                    return new int[] { indexNo,i};
                    //sonuç çıktı demek
                }

            }

            return new int[] {  };
        }

        public int[] OptimumWay(int[] nums, int target, out int timecomp)
        {
            timecomp = 0;
            int left = 0;
            int indexNumber = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                left = target - nums[i];

                timecomp++;
                indexNumber = Array.IndexOf(nums, left,i+1);
                if (indexNumber != -1)
                {
                    //Console.WriteLine("num[" + i + "]=" + nums[i] + " + " + "num[" + indexNumber + "]=" + nums[indexNumber] + " = " + target);
                    //Console.WriteLine("Optimum Time:" + timecomp);
                    return new int[] { i,indexNumber};
                }
            }

            //Console.WriteLine("Optimum Time:" + timecomp);
            return new int[] { };
        }


        public int[] BasicWay(int[] nums, int target,out int timecomp)
        {
            timecomp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    timecomp++;
                    if ((nums[i] + nums[j]) == target)
                    {
                        //Console.WriteLine("num[" + i + "]=" + nums[i] + " + " + "num[" + j + "]=" + nums[j] + " = " + target);
                        return new int[] { i,j};
                    }
                }
            }
            
            return new int[] {};
        }
    }
}

/*
     Hashtable table = new Hashtable();

            int i = 0;
            while (i < nums.Length) {
                
                if(table[nums[i]]!=null){
                return new int[] { (int)table[nums[i]], i };    
                }
                
                table[target - nums[i]] = i;
                i++;
            }

            return new int[] { };
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{

    internal class FindLastKDigit
    {

        public FindLastKDigit() {
            Console.WriteLine("Q - Given two numbers, always print the last two digits of the product.");//product = Carpim demek

            int[] nums = new int[] { 22, 31, 44, 27, 37, 43 };

            int timeCost = 0;
            string basicRes = WayOne(nums,2, out timeCost);
            Console.WriteLine("Input 1: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "] TimeCost:{0}", timeCost);


            string res2 = lastKDigits(nums, 2, out timeCost);
            Console.WriteLine("Input 1: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", res2) + "] TimeCost:{0}", timeCost);


            string res3 = WaySecond(nums, 2, out timeCost);
            Console.WriteLine("Input 1: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", res3) + "] TimeCost:{0}", timeCost);
        }



        public string WaySecond(int[] nums, int k, out int timeCost)
        {
            int div = (int)Math.Pow(10, k);


            timeCost = 0;
            Int64 sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum = (sum * nums[i])%div;
                timeCost++;
            }

            timeCost++;

            return sum.ToString();
        }



        //bu durumda tasma olacaktir.
        public string WayOne(int[] nums, int k, out int timeCost) {
            timeCost = 0;
            Int64 sum = nums[0];
            for (int i = 1;i < nums.Length;i++) { 
                sum=sum * nums[i];
                timeCost++;
            }

            timeCost++;

            return sum.ToString().Substring(sum.ToString().Length - k, k);
        }


        static string lastKDigits(int[] a, int k, out int timeCost)
        {
            timeCost= 1;
            int num = (int)(Math.Pow(10, k));

            // Multiplying array elements
            // under modulo 10^k.
            int mul = a[0] % num;

            for (int i = 1; i < a.Length; i++)
            {
                timeCost++;
                a[i] = a[i] % num;
                mul = (a[i] * mul) % num;
            }


            return mul.ToString();
        }

    }
}

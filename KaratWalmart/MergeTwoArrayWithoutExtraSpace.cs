using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class MergeTwoArrayWithoutExtraSpace
    {
        public MergeTwoArrayWithoutExtraSpace()
        {
            Console.WriteLine("Q - Merge two arrays without using extra space.");

            int[] arr1 = new int[] { 6, 2 };
            int[] arr2 = new int[] { 9, 7, 1, 8 };
            Console.WriteLine("FirstWay");
            Console.WriteLine("Input 1: [" + String.Join(" , ", arr1) + "]");
            Console.WriteLine("Input 2: [" + String.Join(" , ", arr2) + "]");
            int timeCost = 0;
            int[] basicRes = FirstWay(arr1, arr2, out timeCost);
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");




            Console.WriteLine("SecondWay [====================================================================================================]");
            int[] arr11 = new int[] { 6, 2 };
            int[] arr22 = new int[] { 9, 7, 1, 8 };
            Console.WriteLine("Input 1: [" + String.Join(" , ", arr11) + "]");
            Console.WriteLine("Input 2: [" + String.Join(" , ", arr22) + "]");
            int[] secondRes = SecondWay(arr11, arr22, out timeCost);
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");


            Console.WriteLine("ThirddWay [====================================================================================================]");
            int[] arr111 = new int[] { 6, 2 };
            int[] arr222 = new int[] { 9, 7, 1, 8 };
            Console.WriteLine("Input 1: [" + String.Join(" , ", arr111) + "]");
            Console.WriteLine("Input 2: [" + String.Join(" , ", arr222) + "]");
            int[] Res3 = ThirdWay(arr111, arr222, out timeCost);
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");

            /*
             4 5
1 3 5 7
0 2 6 8 9
             */

            Console.WriteLine("FourthWay [====================================================================================================]");
            int[] arr14 = new int[] { 1, 3, 5, 7 };
            int[] arr24 = new int[] { 0, 2, 6, 8, 9 };
            Console.WriteLine("Input 1: [" + String.Join(" , ", arr14) + "]");
            Console.WriteLine("Input 2: [" + String.Join(" , ", arr24) + "]");
            int[] Res4 = FourthWay(arr14, arr24, out timeCost);
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");

        }


        public int[] FourthWay(int[] arr1, int[] arr2, out int timeCost)
        {
            int n = arr1.Length - 1;
            int m = arr2.Length - 1;
            timeCost = 0;


            for (int i = n - 1; i >= 0; i--)
            {
                timeCost++;

                /* Find the smallest element greater than ar2[i]. Move all 
                elements one position ahead till the smallest greater 
                element is not found */
                int j, last = arr1[m - 1];
                for (j = m - 2; j >= 0 && arr1[j] > arr2[i]; j--)
                {
                    timeCost++;
                    arr1[j + 1] = arr1[j];
                }


                // If there was a greater element 
                if (last > arr2[i])
                {
                    arr1[j + 1] = arr2[i];
                    arr2[i] = last;
                }
            }


            Console.WriteLine("Out 1: [" + String.Join(" , ", arr1) + "]");
            Console.WriteLine("Out 2: [" + String.Join(" , ", arr2) + "]");

            return null;
        }


        public int[] ThirdWay(int[] nums1, int[] nums2, out int timeCost)
        {
            timeCost = 0;
            int i = 0;
            int j = 0;
            int tmp = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                timeCost++;
                if (nums1[i] < nums2[j])
                {
                    j++;
                    continue;
                }


                if (nums1[i] > nums2[j])
                {
                    tmp = nums1[i];
                    nums1[i] = nums2[j];
                    nums2[j] = tmp;
                    i++;
                    continue;
                }
            }

            Array.Sort(nums2);

            Console.WriteLine("Out 1: [" + String.Join(" , ", nums1) + "]");
            Console.WriteLine("Out 2: [" + String.Join(" , ", nums2) + "]");

            return null;
        }

        public int[] SecondWay(int[] nums1, int[] nums2, out int timeCost)
        {
            timeCost = 0;
            int count = 0;
            int tmp = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {

                    timeCost++;
                    if (nums2[i] < nums1[j])
                    {
                        tmp = nums2[i];
                        nums2[i] = nums1[j];
                        nums1[j] = tmp;
                        continue;
                    }
                }
            }

            Array.Sort(nums2);





            Console.WriteLine("Out 1: [" + String.Join(" , ", nums1) + "]");
            Console.WriteLine("Out 2: [" + String.Join(" , ", nums2) + "]");
            /*
            var output = firstArray.Union(secondArray);
            var concat = firstArray.Concat(secondArray);
             */


            return null;
        }




        public int[] FirstWay(int[] nums1, int[] nums2, out int timeCost)
        {
            timeCost = 0;
            int count = 0;
            foreach (int ii in nums1.Concat(nums2).OrderBy(x => x))
            {
                timeCost++;
                if (nums1.Length - 1 >= count)
                {
                    nums1[count] = ii;
                    count++;
                    continue;
                }
                nums2[count - nums1.Length] = ii;

                count++;
            }


            Console.WriteLine("Out 1: [" + String.Join(" , ", nums1) + "]");
            Console.WriteLine("Out 2: [" + String.Join(" , ", nums2) + "]");
            /*
            var output = firstArray.Union(secondArray);
            var concat = firstArray.Concat(secondArray);
             */


            return null;
        }


    }
}

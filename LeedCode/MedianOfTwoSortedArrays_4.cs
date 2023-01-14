using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class MedianOfTwoSortedArrays_4
    {


        public MedianOfTwoSortedArrays_4() {
            Console.WriteLine("<<== 4. Median of Two Sorted Arrays ============================================================================>>");

            int[] nums1 = new int[] { 1,2,3 };
            int[] nums2 = new int[] { 4 };
            //nums2 = [2]

            double rec = FindMedianSortedArrays(nums1,nums2);

            Console.WriteLine("Input: [" + String.Join(" , ", nums1) + "] ");
            Console.WriteLine("Input: [" + String.Join(" , ", nums2) + "] ");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }


        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //int[] arr = nums1.Union(nums2).ToArray().OrderBy(x=>x).ToArray(); // bu dublicate leri siler
            int[] arr = nums1.Concat(nums2).ToArray().OrderBy(x => x).ToArray(); // bu olduğu gibi birleştirir

            double mid = (arr.Length / 2);
            int midPlus = (int)Math.Round(mid, MidpointRounding.AwayFromZero);

            if (arr.Length % 2 == 0)
            {//çift
                double toplam = arr[midPlus] + arr[midPlus - 1];
                return toplam / 2;
            }
            else
            {
                return arr[midPlus];
            }

            Console.WriteLine("Merge: [" + String.Join(" , ", arr) + "] ");

            return 0;
        }
    }
}

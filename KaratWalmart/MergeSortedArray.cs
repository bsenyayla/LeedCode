using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class MergeSortedArray
    {
        public MergeSortedArray()
        {
/*
    88. Merge Sorted Array
https://leetcode.com/problems/merge-sorted-array/

You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    */

            Console.WriteLine("Q - Merge two arrays without using extra space.");

            int[] arr1 = new int[] { 6, 2 };
            int[] arr2 = new int[] { 9, 7, 1, 8 };
            Console.WriteLine("FirstWay");
            Console.WriteLine("Input 1: [" + String.Join(" , ", arr1) + "]");
            Console.WriteLine("Input 2: [" + String.Join(" , ", arr2) + "]");
            int timeCost = 0;
            //int[] basicRes = FirstWay(arr1, arr2, out timeCost);
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
        }



    }
}
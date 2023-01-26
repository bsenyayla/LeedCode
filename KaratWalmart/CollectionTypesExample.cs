using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class CollectionTypesExample
    {
        public CollectionTypesExample() {
            Console.WriteLine("Collection Kullanimi");

            ArrayList();
            int[] nums = new int[] { 1, 2, 2, 2, 3, 4, 1 };
            Single(nums);
        }

        public void Single(int[] nums)
        {
            Console.WriteLine("BEGIN");
            int[] vals=nums.GroupBy(x => x).Where(x => x.Count() < 2).Select(x => x.First()).ToArray();



            foreach (int x in vals) { 
                Console.WriteLine("Val: " + x);
            }
            Console.WriteLine("END");

        }


        public void ArrayList() {
            Console.WriteLine(" ArrayList Kullanimi =================================================================");

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("1");
            list.Add("cagatay");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            

            List<String> strList = new List<string>();
            strList.Add("Bahadir");
            strList.Add("xx");
            strList.Add("zzz");

            foreach (var item in strList)
            {
                Console.WriteLine($"{item}");
            }






        }




    }
}

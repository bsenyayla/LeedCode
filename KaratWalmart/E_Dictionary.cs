using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KaratWalmart.E_HashTable;

namespace KaratWalmart
{
    internal class E_Dictionary
    {
    
        public E_Dictionary() {

            Console.WriteLine("Dictionary ================================================================");
            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("Hard Disk", 1280);
            productList.Add("Monitor", 3000);
            productList.Add("SSD Disk", 3500);
            productList.Add("RAM", 2450);
            productList.Add("Processor", 7680);
            productList.Add("Bluetooth", 540);
            productList.Add("Keyboard", 1130);

            var resPro = productList.Where(x => x.Key.Contains("RAM")).ToList();

            Console.WriteLine("Dictionary Select sonucu ....................");
            foreach (var inRec in resPro)
            {
                Console.WriteLine("Key:" + inRec.Key + "Value:" + inRec.Value);

            }

        }



        public bool DictionaryExample(string nums, out int timeCost)
        {
            List<Type_2> list_1 = new List<Type_2>();
            Dictionary<String, Int32> dicList1 = new Dictionary<string, int>();

            list_1.Add(new Type_2() { Key = "A", Value = 3 });
            list_1.Add(new Type_2() { Key = "B", Value = 3 });
            list_1.Add(new Type_2() { Key = "C", Value = 3 });
            list_1.Add(new Type_2() { Key = "D", Value = 3 });


            dicList1 = list_1.ToDictionary(x => x.Key, x => x.Value);
            foreach (Type_2 rec in list_1)
            {

                Console.WriteLine("Key:" + rec.Key + " Value:" + rec.Value);
            }
            Console.WriteLine("\n\n");

            //dicList1.ElementAt()


            timeCost = 0;
            Dictionary<String, Int32> dicList = new Dictionary<string, int>();

            dicList.Add("A", 1);
            dicList.Add("B", 2);
            dicList.Add("C", 3);
            dicList.Add("D", 4);

            string str = dicList["A"].ToString();

            Console.WriteLine("Str Val:" + str);



            int[] arr1 = new int[] { 1, 3, 44, 6 };

            Dictionary<Int32, Boolean> dic2 = arr1.ToDictionary(x => x, y => true);
            foreach (KeyValuePair<String, Int32> pair in dicList)
            {
                Console.WriteLine(pair);
            }

            return false;
        }
    }
}

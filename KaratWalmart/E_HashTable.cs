using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KaratWalmart.MiniGame;

namespace KaratWalmart
{
    internal class E_HashTable
    {
        public class Type_2
        {
            public String Key;
            public Int32 Value;
        }

        public E_HashTable() {
            Console.WriteLine("HashTable kullanimi _____________________________________________________________________________________________");

            var tiles_1 = "88844";
            var tiles_2 = "99";
            var tiles_3 = "55555";
            var tiles_4 = "22333333";
            var tiles_5 = "73797439949499477339977777997394947947477993";
            var tiles_6 = "111333555";
            var tiles_7 = "42";
            var tiles_8 = "888";
            var tiles_9 = "100100000";
            var tiles_10 = "346664366";
            var tiles_11 = "8999998999898";
            var tiles_12 = "17610177";
            var tiles_13 = "600061166";
            var tiles_14 = "6996999";
            var tiles_15 = "03799449";
            var tiles_16 = "64444333355556";
            var tiles_17 = "7";

            string nums = tiles_1;
            int timeCost = 0;
            //Boolean basicRes = HashtableExample(nums, out timeCost);
            //Boolean basicRes = DictionaryExample(nums, out timeCost);
            Boolean basicRes = HashSetExample(nums, out timeCost);

            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", nums) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
        }

        /*
         HashSet uniq eleman tutmaya yarar
         */
        public bool HashSetExample(string nums, out int timeCost)
        {
            Console.WriteLine("HashSet kullanimi _________________________");
            String[] strArr = new String[] {
                
                "A",
                "B",
                "C",
                "D",
                "A",
                "D"
            };

            timeCost= 0;
            HashSet<string> list = new HashSet<string>(strArr);

            foreach (String str in list)
            {
                Console.WriteLine("Val:" + str);
            }


            Console.WriteLine("Sonuc:" + String.Join(",", strArr));
            return false;



            /*
             * Bu iki str de ayni olanlari donduren super bir kod parcasi
                     char[] array1 = { 'a', 'b', 'c' };
                    char[] array2 = { 'b', 'c', 'd' };

                    var hash = new HashSet<char>(array1);
                    hash.SymmetricExceptWith(array2);

                    // Write char array.
                    Console.WriteLine(hash.ToArray());

             */
        }


        public bool DictionaryExample(string nums, out int timeCost)
        {
            List<Type_2> list_1 = new List<Type_2>();
            Dictionary<String, Int32> dicList1 = new Dictionary<string, int>();

            list_1.Add(new Type_2() { Key="A",Value=3});
            list_1.Add(new Type_2() { Key = "B", Value = 3 });
            list_1.Add(new Type_2() { Key = "C", Value = 3 });
            list_1.Add(new Type_2() { Key = "D", Value = 3 });


            dicList1 = list_1.ToDictionary(x => x.Key, x => x.Value);
            foreach (Type_2 rec in list_1) {

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



            int[] arr1 = new int[] { 1,3,44,6};

            Dictionary<Int32,Boolean> dic2=arr1.ToDictionary(x => x, y => true);

            foreach (KeyValuePair<String, Int32> pair in dicList)
            {
                Console.WriteLine(pair);
            }

            return false;
        }

        public bool HashtableExample(string nums, out int timeCost)
        {
            timeCost = 0;

            Hashtable hashtable = new Hashtable();
            hashtable[1] = "One";
            hashtable[2] = "Two";
            hashtable[13] = "Thirteen";


            Console.WriteLine("Dictionary ...");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("Key: {0}, Value:{1}", entry.Key, entry.Value);
            }
            Console.WriteLine("\n\n");
            return false;
        }
    }
}

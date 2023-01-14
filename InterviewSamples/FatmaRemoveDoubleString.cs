using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSamples
{
    public class FatmaRemoveDoubleString
    {

        public FatmaRemoveDoubleString() {
            Console.WriteLine("== Fatma Operations ==============================================================================================");


            //DSStringArray[] drr = new DSStringArray[4];

            //for (int i = 0; i < drr.Length; i++) {
            //    drr[i] = new DSStringArray();
            //}


            RemoveRepeatedStringFromStringArray(new String[] { "bir","üç", "iki", "dört", "iki", "bir", "dört" });
        }




        public void RemoveRepeatedStringFromStringArray(String[] myStringArray) {
            Console.WriteLine("d");
            //better Way
            String[] listStr=myStringArray.GroupBy(x => x)
                .Where(grp => grp.Count() < 2)
                .Select(grp => grp.Key).ToArray();


/*
 Company
    .GroupBy(c => c.Name)
    .Where(grp => grp.Count() > 1)
    .Select(grp => grp.Key);
 */

            List<String> list = new List<string>();

            for (int i = 0; i < myStringArray.Length; i++) {
                String toCompare = myStringArray[i];
               for (int j = i + 1; j < myStringArray.Length; j++) {
                    if (toCompare.Equals(myStringArray[j])) {
                        list.Add(toCompare);
                    }
                }
            }





            for (int j = 0; j < list.Count; j++) {


                


                for (int i = 0; i < myStringArray.Length; i++) {
                    if (myStringArray[i] == list.ElementAt(j)) {
                        myStringArray = removeTheElement(myStringArray, i);
                        i--;
                    }
                }

            }


            string strsd = "";
        }

        public static String[] removeTheElement(String[] arr, int index) {
            if (arr == null || index < 0 || index >= arr.Length) {
                return arr;
            }
            String[] anotherArray = new String[arr.Length - 1];

            int k = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (i == index) {
                    continue;
                }
                
                anotherArray[k] = arr[i];
                k++;
            }
            return anotherArray;
        }
    }
}



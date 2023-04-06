using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewSamples
{
    public class StringOperations {


        public int[] RotateArray(int[] arry) {
            Console.WriteLine("== RotateArray");
            if (arry.Length == 0) return arry;

            Int16 prev = new Int16();
            Int16 tmp = new Int16();
            for (int i = 0; i < arry.Length; i++) {
                tmp = (Int16)arry[i];
                arry[i] = prev;
                prev = (Int16)tmp;
            }

            arry[0] = prev;
            Console.WriteLine(String.Join(" , ", arry));
            return arry;
        }

        public StringOperations(String strVal) {
            Console.WriteLine("== String Operations ==============================================================================================");
            /*
            //this.getNotRepeadMoreThanOne(new String[] { "üç","bir", "iki", "dört","iki", "bir","dört" });
            //this.getNotRepadMoreThanOne_1(new String[] {  "bir", "iki", "dört", "üç", "iki", "bir", "dört" });

            //this.tt(new String[] { "üç", "bir", "iki", "dört", "iki", "bir", "dört" });
            this.ArraySortSample(new String[] { "üç", "bir", "iki", "dört", "iki", "bir", "dört" });

            ReverseString("Bahadır");
            DublicateCharacters("Bahadır");

            CheckNumberOrString("Bah23adır");

            int[] res = RotateArray(new int[] { 1, 2, 3, 4, 5 });
            res = RotateArray(res);

            //CheckAnagram(new String[] { "üç", "bir", "iki", "dört", "iki", "bir", "dört" });
            CheckAnagram("word", "wrod");
            CheckAnagramOpt("word", "wrod");
            StringArrayElementRemoveSample("word", "wrod");


            //StringCharactersSort("FDACBE");

            */
            /*
            "mary", "army"
            "stop", "tops"
            "boat", "btoa"
            "pure", "in"
            "fill", "fil"
            "b", "bbb"
            "ccc", "ccccccc"
            "a", "a"
            "sleep", "slep"*/

            //1 2 3 2 5 7

            //1 + (2+1=3) + 3 + (2 + 1=3) + 5 + 7 =22
            /*
                     arr.Add(2);
        arr.Add(8);
        arr.Add(2);
        arr.Add(6);
        arr.Add(9);    
         */


            List<int> arr = new List<int>();
            //arr.Add(1);
            //arr.Add(2);
            //arr.Add(3);
            //arr.Add(2);
            //arr.Add(5);
            //arr.Add(7);

            arr.Add(1);
            arr.Add(1);
            arr.Add(1);
            arr.Add(1);
         
            Console.WriteLine("Result: " +getMinimumUniqueSum(arr));

            String sdfsdf = "";


            CheckStringSyntx(sdfsdf);
        }


        /*
         Input: s = "()[]{}" Output: true Example 3: Input: s = "(]" 

             */

        public void CheckStringSyntx(String str) {

        }



        public static int simpleArraySum(List<int> ar) {

            
//6 1 2 3 4 10 11
        return ar.Sum();
        }

        #region GetMinimumUniqueSum
        public int getMinimumUniqueSum(List<int> arr) {
            int sum = 0;
            for (int j=0;j < arr.Count; j++) {
                bool isUniq=IsUniq(arr, j, arr[j]);
                if (isUniq == true) {
                    sum += arr[j];
                }
                else {
                    int tmpNumber = arr[j];
                    bool tmpisUniq = false;
                    do {
                        tmpNumber++;
                        tmpisUniq = IsUniq(arr, 0, tmpNumber);

                    } while (tmpisUniq == false);
                    sum += tmpNumber;
                }
            }
            return sum;
        }

        public bool IsUniq(List<int> arr,int beginIndex,int checkNumber) {
            int count = 0;
            for (int i = 0; i < arr.Count; i++) {
                if (checkNumber == arr[i]) {
                    count++;
                }
            }
            return (count==0 ? true : false);
        }
        #endregion GetMinimumUniqueSum


        // public static boolean checkAnagram(String first, String second) {
        /* CheckAnagram - array yada string remove eleminasyon yönetmi ile */
        public void StringArrayElementRemoveSample(String first, String second) {
            Console.WriteLine("\n== Anagram Çözüm yolu 3 - Eliminasyon");
            char[] characters = first.ToArray();

            foreach (char ch in characters) {
                int index = second.IndexOf(ch);
                    
                if (index != -1) {
                    second=second.Remove(index,1);
                }
                else {
                    Console.WriteLine("Anagram değil..");
                    return;
                }
            }

            if (second.Length != 0) {
                Console.WriteLine("Anagram değil..");
                return;
            }
                
            Console.WriteLine("Anagram");
        }

        public void StringCharactersSort(String str) {
            Console.WriteLine("== String Characters Sort ");

            Console.Write("Input: " + str + "\nOutPut: ");

            var letters = new SortedSet<char>("FDACBE");
            foreach (char c in letters) {
                Console.Write(c); // ABCEF
            }
        }

        //string leri order ederek kontrol etmek
        public void CheckAnagramOpt(String strFirst, String strSecond) {
            Console.WriteLine("\n== Anagram Çözüm yolu 2 - String Order yöntemi ile");
            if (strFirst.Length != strSecond.Length || strFirst.Length == 0) {
                Console.WriteLine("Anagram Değil !");
                return;
            }

            String arr1 = String.Concat(strFirst.OrderBy(x => x));
            String arr2 = String.Concat(strSecond.OrderBy(x => x));

            if (String.Equals(arr1, arr2)) {
                Console.WriteLine("Anagram ");
                return;
            }

            Console.WriteLine("Anagram Değil !");
        }

        public void CheckAnagram(String strFirst, String strSecond) {
            Console.WriteLine("\n== Anagram Çözüm yolu 1 - iki boyutlu array kullanarak");
            if (strFirst.Length == 0 || strSecond.Length == 0) return;
            if (strFirst.Length != strSecond.Length) {
                Console.WriteLine("Anagram Değil !");
                return;
            }

            char[,] tmp = new char[strFirst.Length, 2];
            char res = '0';

            for (int j = 0; j < strFirst.Length; j++) {

                res = '0';
                for (int i = 0; i < strSecond.Length; i++) {
                    tmp[i, 0] = strSecond[i];
                    if (strFirst[j] == strSecond[i] && tmp[i, 1] != 'x') {
                        tmp[i, 1] = 'x';
                        res = tmp[i, 1];
                        break;
                    }
                }

                if (res != 'x') {
                    Console.WriteLine("Anagram değil");
                    return;
                }
            }

            Console.WriteLine("Anagram..");
        }




        //dizideki tekrar etmeyen elemanı verin
        public void getNotRepeadMoreThanOne(String[] inVal) {
            StringBuilder retVal = new StringBuilder();

            Boolean isDouble = false;
            for (int i = 0; i < inVal.Length; i++) {
                //Console.WriteLine("Eleman: " + inVal[i]);

                isDouble = false;
                for (int j = 0; j < inVal.Length; j++) {
                    if (i == j) { continue; }

                    if (inVal[i] == inVal[j]) {
                        isDouble = true;
                        break;
                    }

                    //Console.WriteLine("Eleman=>  " + inVal[j]);
                }

                if (isDouble == false) {
                    Console.WriteLine("Tekil => " + inVal[i]);
                }
            }


            Console.WriteLine("Tekrarsız elemanlar =>" + retVal);
        }

        //sort yolu ile çözüldü
        public void getNotRepadMoreThanOne_1(String[] inVal) {
            Console.WriteLine("== Function 2");

            String[] reOrder = inVal.OrderBy(x => x).ToArray();


            String prevVal = null;
            int count = 0;
            foreach (String rec in reOrder) {
                if (prevVal == null) {
                    prevVal = rec;
                    count++;
                    continue;
                }

                if (prevVal == rec) {
                    count++;
                    continue;
                }
                else {

                    if (count == 1) {
                        Console.WriteLine("Tek => " + prevVal);
                    }

                    count = 1;
                    prevVal = rec;

                }
            }

            if (count == 1) {
                Console.WriteLine("Tek => " + prevVal);
            }


        }

        //ilk dobule olanları bulup sonra 2 boyutlu ile tek olanları alıyorum

        public void tt(String[] myStringArray) {
            String[,] CheckArr = new String[myStringArray.Length, 2];

            for (int i = 0; i < myStringArray.Length; i++) {
                String toCompare = myStringArray[i];

                CheckArr[i, 0] = toCompare;
                CheckArr[i, 1] = "0";

                for (int j = 0; j < myStringArray.Length; j++) {
                    if (i == j) continue;
                    if (toCompare.Equals(myStringArray[j])) {
                        Console.WriteLine("Duplicate Name " + toCompare);
                        CheckArr[i, 1] = "1";
                        break;
                    }
                }
            }

            for (int i = 0; i < myStringArray.Length; i++) {
                Console.WriteLine("Eleman:" + CheckArr[i, 0] + " - Sonuc:" + CheckArr[i, 1]);
            }

        }

        public void ReverseString(String str) {
            Console.WriteLine("== Reverse String ===============");

            if (str == null || str.Length == 0) return;

            StringBuilder retVal = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--) {
                retVal.Append(str[i]);

            }

            Console.WriteLine(retVal);
        }

        public void DublicateCharacters(String str) {
            Console.WriteLine("== Dublicate Characters ===============");
            if (str == null || str.Length == 0) return;

            Hashtable dc = new Hashtable();
            foreach (char c in str) {
                if (dc.Contains(c)) {
                    if ((int)dc[c] == 1) {
                        Console.WriteLine("Dublicate: " + c);
                    }

                    dc[c] = 2;
                }
                else {
                    dc.Add(c, 1);
                }
            }
        }

        public void CheckNumberOrString(String str) {
            Console.WriteLine("== Dublicate Characters ===============");
            if (str == null || str.Length == 0) return;

            foreach (char cc in str) {
                if (char.IsNumber(cc)) {
                    Console.WriteLine("Number:" + cc);
                }
            }


            //regulare expression ile kullanımı
            //Regex desen = new Regex("^[0-9]*$");
            //return desen.IsMatch(strVeri);

        }



        public void ArraySortSample(String[] myStringArray) {


            Array.Sort(myStringArray,
                        (x, y) => x.Length.CompareTo(y.Length)
                );


            //foreach (String rec in myStringArray) {
            //    Console.WriteLine("E:" + rec);
            //}

            Console.WriteLine(String.Join(" , ", myStringArray));



            //Enumerable -Linq kullanımı
            string[] sorted = myStringArray.OrderBy(x => x).ToArray();


            Console.WriteLine(String.Join(", ", sorted));
        }


    }
}

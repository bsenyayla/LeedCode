using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class ReverseStringWithoutAlterSpecialCharactes
    {

        
        public ReverseStringWithoutAlterSpecialCharactes()
        {
            Console.WriteLine("Reverse a string without altering the position of any special characters present in the string.");

            String strVal = "Ab,c,de!$”";

            int k = 4, timeCost = 0;
            string basicRes = FirstWay(strVal, k, out timeCost);
            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", strVal) + "] , k={0}", k);
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
            Console.WriteLine("\n================================================================================");


            
            string secondRes = SecondWay(strVal, k, out timeCost);
            Console.WriteLine("SecondWay");
            Console.WriteLine("Input: [" + String.Join(" , ", strVal) + "] , k={0}", k);
            Console.WriteLine("Output: [" + String.Join(" , ", secondRes) + "]");
            Console.WriteLine("Time: [" + String.Join(" , ", timeCost) + "]");
            Console.WriteLine("\n================================================================================");
        }

        //"Ab,c,de!$”";
        public string SecondWay(String stext, int k, out int timecomp)
        {
            timecomp = 0;
            int l = 0, r = stext.Length - 1;
            char[] chText = stext.ToCharArray();

            while (l < r)
            {
                timecomp++;
                if (!char.IsLetter(chText[l]))
                {
                    l++;
                }
                else if (!char.IsLetter(chText[r]))
                {
                    r--;
                }
                else {
                    chText[l] = chText[r];
                    l++;
                    r--;
                }

            }

            return string.Join("",chText);
        }



        /*
            Regex rgx = new Regex(@"[^a-zA-Z0-9]"); //bunun dışındaki istenmeyen karakterler strinden çıkarılır.
            s =rgx.Replace(s, "").ToLower();
        */

        public string FirstWay(String strVal, int k, out int timecomp)
        {
            Regex rg = new Regex(@"[^a-zA-Z]");
            timecomp = 0;

            string cleanedStr = rg.Replace(strVal, "");
            char[] reverseChr = cleanedStr.Reverse().ToArray();

            char[] orjStr = strVal.ToCharArray();

            int secondIndex = 0;
            for (int i = 0; i < strVal.Length; i++)
            {
                if (!char.IsLetter(orjStr[i])) { continue; }

                orjStr[i] = reverseChr[secondIndex];
                secondIndex++;


                timecomp++;
            }


            //var reverseText = string.Join("", s.ToLower().Reverse());
            //string reverseStr=String.Join("", cleanedStr.Reverse());



            return string.Join("", orjStr); ;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    /*
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000 
    */
    class RomanToInt
    {

        public RomanToInt()
        {
            Console.WriteLine("<<== Roman to Int ============================================================================>>");
            String s = "MCMXCIX";

            int rec = calc1(s);


            Console.WriteLine("Input: [" + String.Join(" , ", s) + "] ");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");


            Console.WriteLine("Tested Output: [" + String.Join(" , ", calc(s)) + "]"); 
            

        }


        public Hashtable htRoman = new Hashtable();

        public int calc1(string roman)
        {
            
            htRoman["I"] = 1;
            htRoman["V"] = 5;
            htRoman["X"] = 10;
            htRoman["L"] = 50;
            htRoman["C"] = 100;
            htRoman["D"] = 500;
            htRoman["M"] = 1000;

            Int32 beforeVal = 0;
            Int32 total = 0;
            //foreach (Char curRomanStr in roman.Trim().ToList())
            //{
            //    Int32 currVal = Convert.ToInt32(htRoman[curRomanStr.ToString()]);


            //    if (beforeVal < currVal)
            //    {
            //        total += currVal - (beforeVal * 2);
            //    }
            //    else
            //    {
            //        total += currVal;
            //    }


            //    beforeVal = currVal;
            //}


            for (int i = 0; i < roman.Length; i++) {

                if (i!=0 && getVal(roman[i - 1]) < getVal(roman[i]))
                {
                    total += getVal(roman[i]) - (getVal(roman[i - 1]) * 2);
                }
                else
                {
                    total += getVal(roman[i]) ;
                }

            }


            return total;
        }

        private Int32 getVal(Char chr) {
            return Convert.ToInt32(htRoman[chr.ToString()]); ;
        }

        public int calc(string roman)
        {
            Int32 retVal = 0;

            Hashtable table = new Hashtable();
            table["I"] = 1;
            table["V"] = 5;
            table["X"] = 10;
            table["L"] = 50;
            table["C"] = 100;
            table["D"] = 500;
            table["M"] = 1000;


            string curNumStr = "";
            Int32 curNum = 0;
            Int32 prevNum = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                curNumStr = roman.Substring(i, 1);
                curNum = Convert.ToInt32(table[curNumStr].ToString());

                if (i == 0)
                {
                    retVal = curNum;
                    continue;
                }


                if (prevNum != 0)
                {
                    if (prevNum < curNum)
                    {
                        retVal += curNum - prevNum;
                        prevNum = 0;
                        continue;
                    }
                    else
                    {
                        retVal += curNum + prevNum;
                        prevNum = 0;
                        continue;
                    }
                }

                prevNum = curNum;
            }

            if (prevNum != 0)
            {
                retVal += prevNum;
            }

            return retVal;
        }


    }
}

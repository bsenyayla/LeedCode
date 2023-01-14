using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class Sil
    {
        public Sil() {
            Console.WriteLine("<<== 125. Valid Palindrome ============================================================================>>");

            //string s = "A man ?, a plan,# a canal: Panama@";
            string s = "MCMXCIV";
            calc(s);

        }

        public void calc(string strRoman) {
            Console.WriteLine("Gelen rakam :{0}",strRoman);

            Hashtable table = new Hashtable();
            table.Add("M", 1000);
            table.Add("D", 500);
            table.Add("C", 100);
            table.Add("L", 50);
            table.Add("X", 10);
            table.Add("V", 5);
            table.Add("I", 1);


            Int32 total = 0;
            Int32 prevValue = 0;
            Int32 currValue = 0;
            char[] arrRoman = strRoman.ToCharArray();
            for(int i=0;i < arrRoman.Length;i++) {
                currValue = (Int32)table[arrRoman[i].ToString()];

                if (prevValue < currValue && prevValue!=0) {
                    total += currValue - (prevValue * 2);
                }
                else {
                    total += currValue;
                }

                prevValue = currValue;
            }



            Console.WriteLine("Toplam:{0}", total);
        }
        

    }
}

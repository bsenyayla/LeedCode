using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeedCode
{
    class CheckPalindrome_CodeSignal
    {

/*
Given an integer x, return true if x is a palindrome, and false otherwise.
*/
        public CheckPalindrome_CodeSignal() {
            Console.WriteLine("<<== 125. Valid Palindrome ============================================================================>>");

            //string s = "A man ?, a plan,# a canal: Panama@";
            string s = "12345";

            bool rec = IsPalindrome( s);
            //bool rec = IsPalindrome_Way2(s);

            Console.WriteLine("Input: [" + String.Join(" , ", s) + "] ");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }

        public bool IsPalindrome(string s) {
            Regex rgx = new Regex(@"[^a-zA-Z0-9]"); //bunun dışındaki istenmeyen karakterler strinden çıkarılır.

            s =rgx.Replace(s, "").ToLower();

            return s.SequenceEqual(s.Reverse());


            String str1 = "d";

            Regex rg1 = new Regex(@"[^a-zA-Z0-9]");
            str1=rg1.Replace(str1, "");
            str1.SequenceEqual(str1.Reverse());
        }


        public bool IsPalindrome_Way2(string s) {
            Console.WriteLine("<<== Way 2 ==>>");
            char[] separators = new char[] { '.',',',';','*','?','@','+',':',' ','#'};
            
            string[] temp;
            temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Tmp:" + String.Join("", temp));

            var reverseText = string.Join("", s.ToLower().Reverse());
            return reverseText == s;
        }

        public bool isPalindrome(int x) {
            String str1 = x.ToString();

            char[] tmpchar = str1.ToCharArray();
            Array.Reverse(tmpchar);

            String str2 = new String(tmpchar);


            if (str1 == str2) {
                Console.Write("palindrome");
            }
            return false;
        }
        public bool isPalindromeWay2(int x) {

            string str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++) {

                String str1 = str.Substring(i, 1);
                String str2 = str.Substring((str.Length - 1) - i, 1);

                if (str1 != str2) {
                    Console.Write("değil");
                    return false;
                }
            }


            Console.Write("palindrome");

            return false;
        }
    }
}

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

        public CheckPalindrome_CodeSignal() {
            Console.WriteLine("<<== 125. Valid Palindrome ============================================================================>>");

            //string s = "A man ?, a plan,# a canal: Panama@";
            string s = "12345";

            //bool rec = IsPalindrome( s);
            bool rec = IsPalindrome_Way2(s);

            Console.WriteLine("Input: [" + String.Join(" , ", s) + "] ");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }

        public bool IsPalindrome(string s) {
            Regex rgx = new Regex(@"[^a-zA-Z0-9]"); //bunun dışındaki istenmeyen karakterler strinden çıkarılır.

            s =rgx.Replace(s, "").ToLower();

            return s.SequenceEqual(s.Reverse());
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

    }
}

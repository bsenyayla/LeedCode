using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeedCode
{
    public class Tmp
    {

        public Tmp() {
            //bool rec = isPalindromeWay2(12345);
            bool rec = isPalindromeWay4("A man ?, a plan,# a canal: Panama@");
            
        }

        public bool isPalindromeWay4(string x) {
            Regex reg = new Regex(@"[^a-zA-Z0-9]");
            x=reg.Replace(x, "");

            String s = x.ToString();
            return s.SequenceEqual(s.Reverse());
        }
        
        public bool IsPalindrome_Way2(string s) {
            Console.WriteLine("<<== Way 2 ==>>");
            char[] separators = new char[] { '.', ',', ';', '*', '?', '@', '+', ':', ' ', '#' };

            string[] temp;
            temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Tmp:" + String.Join("", temp));

            var reverseText = string.Join("", s.ToLower().Reverse());
            return reverseText == s;
        }
        
        public bool isPalindromeWay3(int x) {
            String s = x.ToString();
            return s.SequenceEqual(s.Reverse());
        }

    }
}

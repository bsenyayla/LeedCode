using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeedCode
{
    class WildcardMatching_44
    {
        public WildcardMatching_44() {
            Console.WriteLine("<<== 42. Trapping Rain Water ============================================================================>>");


            string s = "adceb";
            string p = "* a*b";





            bool rec = IsMatch(s, p);

            Console.WriteLine("Input: s[" + s  + "]  p[" + p +"]");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }


        public bool IsMatch(string s, string p) {

            string s1 = s.Replace("*", ".*?");
            string s2 = p.Replace("*", ".*?");
            bool r1 = Regex.IsMatch(s1, "^" + s2);
            bool r2 = Regex.IsMatch(s2, "^" + s1);
            return r1 || r2;

            //if (p=="*") return true;
            //if (s.Length != p.Length) return false;

            //bool star = false;

            //for (int i = 0; i < p.Length; i++) {

            //    if (p.ElementAt(i) == '*') {
            //        star = true;
            //        continue;
            //    }


            //    //if (s.ElementAt(i) != p.ElementAt(i) && star == true) {
            //    //    continue;
            //    //}

            //    if (s.ElementAt(i) != p.ElementAt(i) && p.ElementAt(i) !='?' ) {
            //        return false;
            //    }
            //}


            return true;
        }
    }
}

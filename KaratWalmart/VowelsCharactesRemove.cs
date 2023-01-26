using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class VowelsCharactesRemove
    {
        public VowelsCharactesRemove() {
            //A, E, I, O, U, Y, W
            Console.WriteLine("Q - In a given string, remove all the vowels and then trim the empty spaces on either side of the string");

            string words = "ABCDEFGHIJKMKLMNOXYUZ";
            
            Console.WriteLine("FirstWay");
            Console.WriteLine("Input 1: [" + String.Join(" , ", words) + "]");
            int timeCost = 0;
            string basicRes = WayOne(words, out timeCost);
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "] TimeCost:{0}",timeCost);

            string Res2 = WaySecond("ABCDiiEFGHIJKMKLMNOXYUZ", out timeCost);
            Console.WriteLine("Output: [" + String.Join(" , ", Res2) + "] TimeCost:{0}", timeCost);


        }

        public string WayOne(string words,out int timeCost) {
            timeCost = 1;
            char[] separators = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'W'};
            string[] temp = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            words = String.Join("", temp);

            return words;
        }

        public string WaySecond(string words, out int timeCost)
        {
            timeCost = 1;

            Regex rg=new Regex(@"[aeiou]");
            words=rg.Replace(words.ToLower(),"");

            return words;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class ReverseString
    {
        public ReverseString() {
            ReverseStringP("Bahadır");
            //ReverseWordOrder("Bahadır bir iki 1 2 3");
            
        }



        private void ReverseStringP(string str) {

            //Way 1
            Char[] chrAA = str.ToCharArray();
            Array.Reverse(chrAA);
            String tt = new String(chrAA);
            Console.WriteLine("Way 1 : Result:" + tt);


            //Way2
            Console.WriteLine("=========================================================================================================");
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--) {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedstring = new string(charArray);
            Console.WriteLine("Way 2 :" + reversedstring);
            
        }


        void ReverseWordOrder(string str) {
            int i;
            StringBuilder reverseSentence = new StringBuilder();
            int Start = str.Length - 1;
            int End = str.Length - 1;
            while (Start > 0) {

                if (str[Start] == ' ') {
                    i = Start + 1;
                    while (i <= End) {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }



            for (i = 0; i <= End; i++) {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }


  

    }
}
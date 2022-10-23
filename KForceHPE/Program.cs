using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KForceHPE
{
    class Program
    {
        static void Main(string[] args) {


            String str = "how are you, abc";

            String str1 = str.Split(',')[0];
            String str2= str.Split(',')[1];

            for(int i =0; i )
            


        }




    }
}


/*
 * 
 *             /*
 Input: s = "()[]{}" Output: true Example 3: Input: s = "(]" 

     */


String str = "()[]{}";
            
            String patter = "()[]{}";
            char[] strChar = str.ToArray();


            //6 we 3
            for (int i = 0; i < strChar.Length; i++) {

                if (i%2==0) {
                    int indexNumber = patter.IndexOf(strChar[i]);

                    if (strChar[i + 1] != patter.ElementAt(indexNumber + 1)) {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }


            Console.WriteLine("true");
            Console.Read();
     */

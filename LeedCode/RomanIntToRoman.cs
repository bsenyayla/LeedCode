using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    internal class RomanIntToRoman
    {

        public RomanIntToRoman()
        {

            string ddd = IntToRoman(101);
            Console.WriteLine(ddd);
        }




        public string IntToRoman(int num)
        {
            Console.WriteLine("INT:" + num);

            List<List<string>>  a=new List<List<string>>();
            
            


            string romanResult = string.Empty;
            string[] romanLetters = {
                    "M",
                    "CM",
                    "D",
                    "CD",
                    "C",
                    "XC",
                    "L",
                    "XL",
                    "X",
                    "IX",
                    "V",
                    "IV",
                    "I"
                };

            int[] numbers = {
                    1000,
                    900,
                    500,
                    400,
                    100,
                    90,
                    50,
                    40,
                    10,
                    9,
                    5,
                    4,
                    1
                };

            int i = 0;
            while (num != 0)
            {
                if (num >= numbers[i])
                {
                    num -= numbers[i];
                    romanResult += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            
            Console.WriteLine("Roman:" + romanResult);

            return romanResult;
        }

    }
}
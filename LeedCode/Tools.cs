using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class Tools
    {
        public static void WriteInput(int[] rec) {
            Console.WriteLine("Input: [" + String.Join(" , ", rec) + "]");
        }

        public static void WriteOutput(int[] rec) {
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }


    }
}

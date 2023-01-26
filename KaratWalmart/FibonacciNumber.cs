using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class FibonacciNumber
    {

        public FibonacciNumber() {

            Console.WriteLine("Q - Merge two arrays without using extra space.");

            int a=0;
            int b=1;
            int c=0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < 10; i++) {
                
                c = a + b;

                Console.Write(" {0}", c);
                a = b;
                b = c;

            }


        }


    }
}

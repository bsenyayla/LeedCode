using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class DivideTwoIntegers_29
    {

        public DivideTwoIntegers_29() {
            Console.WriteLine("<<== 29. Divide Two Integers ============================================================================>>");

            int dividend = 2147483647;
            int divisor = -2147483648;
            //nums2 = [2]

            double rec = Divide(dividend, divisor);

            Console.WriteLine("Input: Divident[" + dividend + "] Divisor:" + divisor);
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }


        public int Divide(int dividend, int divisor) {
            //çarpama ,bölme ve mod olmadn bölün

            int result = 0;
            bool sig = false;
            bool dividendP = false;
            bool divisorP = false;
            int divisorPlus = 0;
            int dividendPlus = 0;

            if (divisor < 0) {
                sig = !sig;

                if (divisor == int.MinValue) {
                    divisor++;
                    divisorPlus = 1;
                }
                divisor = -divisor;
                divisorP = true;
            }


            if (dividend < 0) {
                sig = !sig;
                if (dividend == int.MinValue) {
                    dividend++;
                    dividendPlus = 1;
                }
                dividend = -dividend;
                dividendP = true;
            }

            if (divisor == 1) {
                if (sig) {
                    dividend = -(dividend +  (dividendPlus + divisorPlus ));
                }
                return dividend;
            }


            if (dividend < divisor) return 0;

            dividend = dividend - divisor;
            result++;

            dividend += dividendPlus;

            if (divisor != int.MaxValue) {
                divisor += divisorPlus;
            }


            while (dividend >= divisor  )
            {
                dividend = dividend - divisor;
                result++;
            }
            


            if (sig) {

                if (dividendP == true && divisorP == false) {
                    result = -(result);
                    //result = -(result - plus);
               }
               else {
                    result = -(result - (dividendPlus + divisorPlus));
                }

                
            }

            return result;
        }


    }
}

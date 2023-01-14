using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    internal class FindMinNumber
    {
        public FindMinNumber()
        {
            Console.WriteLine("<<== Min Number ============================================================================>>");
            List<int> list = new List<int> { 2,3,78,3,0,7,4,0};
           
            int res = GetLowestValue(list);

            Console.Write("Sonuç : " + res);
        }

        public int GetLowestValue(List<int> inputValues)
        {
            if (inputValues == null) return -1;
            if (inputValues.Count == 0) return -1;

            //Way 1 
            //inputValues.Sort();
            //return inputValues[0];

            //Way 2
            var res =inputValues.OrderBy(x => x).Take(1).SingleOrDefault();
            return (int)res;



        }


        
    }
}

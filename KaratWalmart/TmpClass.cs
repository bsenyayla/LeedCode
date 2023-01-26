using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class TmpClass
    {
        public TmpClass() {

            
        }

        public bool Calc(String words)
        {

            char[] arrStr = words.ToCharArray();
            Array.Sort(arrStr);

            int count = arrStr.Distinct().Count();
            char[] chrDist = arrStr.Distinct().ToArray();

            Hashtable ht = new Hashtable();

            foreach (char chr in chrDist)
            {

                ht[chr] = arrStr.Where(x => x == chr).Count();
            }

            int tripleCount = 0;
            int pairCount = 0;

            foreach (DictionaryEntry de in ht)
            {

                if ((Convert.ToInt16(de.Value) % 2) == 0)
                {
                    pairCount = Convert.ToInt16(de.Value) / 2;
                    continue;
                }

                if ((Convert.ToInt16(de.Value) % 3) == 0)
                {
                    tripleCount = Convert.ToInt16(de.Value) / 3;
                    continue;
                }
            }

            Console.WriteLine("tripleCount:" + tripleCount);
            Console.WriteLine("pairCount:" + pairCount);

            if (pairCount == 1 && tripleCount == 1)
            {
                return true;
            }

            if (pairCount >= 1 && tripleCount == 0)
            {
                return true;
            }

            if (pairCount > 1 && tripleCount > 0)
            {
                return true;
            }


            return false;
        }
    }
}
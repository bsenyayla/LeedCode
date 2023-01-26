using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace KaratWalmart
{
    public class DataStruct_SortAndOrderArray
    {
        private int[] mArr;
        private int arrMaxLen = 0;
        public DataStruct_SortAndOrderArray(int[] arr) {
            mArr = arr;
            arrMaxLen = mArr.Length;


            //Array.Sort(mArr);
            //mArr=mArr.Distinct().ToArray();

            SortOrder();
        }

        public int Len() {
            return arrMaxLen;
        }

        private void SortOrder() {
            int tmp = 0;

            for (int j = 0; j < Len(); j++)
            {
                for (int i = 0; i < Len(); i++)
                {

                    if ((i + 1) >= Len()) continue;

                    if (mArr[i] > mArr[i + 1])
                    {
                        tmp = mArr[i];
                        mArr[i] = mArr[i + 1];
                        mArr[i + 1] = tmp;
                        continue;
                    }

                }
            }

            string sdfs = "";
        }

        

        public int KthSmallest(int k) {
            if (k < 0 || k > arrMaxLen) return -1;

            return mArr[k - 1];
        }


    }
}


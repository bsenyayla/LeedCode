using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSamples
{
    class Program
    {
        static void Main(string[] args) {


            StringOp("Forcefk");

            

            StringOperations fnString = new StringOperations("def value");

            FatmaRemoveDoubleString fnFatma = new FatmaRemoveDoubleString();
            //fnString.getNotRepeadMoreThanOne(new String[] { "bir","iki","üç","dört"});
            Console.ReadLine();
        }






        // büyük yada küçük harf gördüğünde önüne K ekle
        public static void StringOp(String str) {
            StringBuilder retVal = new StringBuilder();
            foreach (char rc in str) {
                if (rc == 'f' || rc == 'F') {
                    retVal.Append("K");
                }
                retVal.Append(rc);
            }
            Console.WriteLine("Sonuç: " + retVal);
        }




       
    }
}

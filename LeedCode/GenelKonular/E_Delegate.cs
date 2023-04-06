using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.GenelKonular
{
    internal class E_Delegate
    {
        delegate void TemsilciTopla(int x, int y);

        /*
         Kisaca soyle diyelim. methodlarin ram deki adreslerini tutar .Ve calisitirilmak istendiginda calisitirilir.
        asil amaci bir method tetiklendiginda birden fazla methodu tetiklemektir.
        Mesela db den bir kayit silindiginde ayni anda log atilmasi , notification goonderilmesi gibi
         */

        public E_Delegate()
        {
            Console.WriteLine("Delege Kullanimi ============================================================================================");

            int a = 2;
            int b = 3;
            //SumInt(a, b);

            TemsilciTopla DTopla = SumInt;
            DTopla += Carpma;
            DTopla(a, b);
        }

        public void SumInt(int a, int b) {
            Console.WriteLine("Toplam:" + (a + b));
        }


        public void Carpma(int a, int b)
        {
            Console.WriteLine("Carpma:" + (a * b));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class KalitimClass : KalitimMirasVerenClass
    {
        public KalitimClass(string ad, string soyad) : base(ad, soyad)
        {
        
        }

        //Bu sınıf içinde Yaz adında bir method yok ama kullanmak istediğimizde bu method miras alınan class dan alınır ve 
        // kullanılabilir.
        //Öreğin

        public void YazTumDetaylari() {

            Console.Write("Tüm Detaylar Yazdırılıyor");
            Yaz();
        }



    }
}

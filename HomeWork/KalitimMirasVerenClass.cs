using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class KalitimMirasVerenClass
    {

        private String ad;
        private String soyad;
        public KalitimMirasVerenClass(String ad,String soyad) {
            ad = ad;
            soyad = soyad;
        }


        public void Yaz() {
            Console.WriteLine("Adı:" + ad + " Soyadı:" + soyad);
        }

    }
}

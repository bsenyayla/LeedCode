using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork
{
    public class Kapsulleme
    {

        /*
         Class dışından bu değişkenlere ulaşamayız .Buna güvenli olarak ulaşmak için Kapsülleme yaparız.
        Burada bu ayarları bizim kontrolümüzde ve istediğimiz şekilde yönetmek için kapsüllüyoruz.
         */
        private String ad;
        private String soyad;
        private Int32 yas;

        public Kapsulleme(String ad,String soyad ,Int32 yas) {

            Ad = ad;
            Soyad = soyad;
            this.yas = yas;
        }



        public String Ad
        {
            get { 
                return Ad; 
            }

            set { 
                ad = value; 
            }
        }

        public String Soyad
        {
            get {
                return soyad;
            }

            set {
                soyad = value;
            }
        }


        public Int32 Yas {
            get 
            { 
                return yas; 
            }
        }






    }
}

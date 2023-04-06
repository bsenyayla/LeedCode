using LeedCode.GenelKonular.Delegate_00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.GenelKonular.Delegate_00
{
    internal class Start
    {

        public Start() {
            DosyaIslemleri islem = new DosyaIslemleri("abc.txt");
            islem.DosyaSilindiginde += MetotCalistir;
            islem.DosyayiSil();
        }

        private void MetotCalistir(object sender, SonucArgs e)
        {
            Console.WriteLine("Dosya: {0}", e.Dosya);
            Console.WriteLine("Mesaj: {0}", e.Mesaj);
            Console.WriteLine("Tarih: {0}", e.Tarih);
        }
    }

}


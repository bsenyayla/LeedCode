using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode.GenelKonular.Delegate_00
{
    internal class SonucArgs:EventArgs
    {
        public string Dosya;
        public string Mesaj;
        public DateTime Tarih;

        public SonucArgs(string dosya, string mesaj, DateTime tarih)
        {
            this.Dosya = dosya;
            this.Mesaj = mesaj;
            this.Tarih = tarih;
        }
    }
}

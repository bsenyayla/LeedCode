using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeedCode.GenelKonular.Delegate_00
{
    internal class DosyaIslemleri
    {
        private string Dosya;
        public EventHandler<SonucArgs> DosyaSilindiginde;  // event

        public DosyaIslemleri(string dosya)
        {
            this.Dosya = dosya;
        }

        public void DosyayiSil()
        {
            if (File.Exists(this.Dosya))
            {

                File.Delete(this.Dosya);
                if (this.DosyaSilindiginde != null)
                {
                    this.DosyaSilindiginde(this, new SonucArgs(this.Dosya, "Dosya silindi.", DateTime.Now));
                }
            }
            else
            {
                if (this.DosyaSilindiginde != null)
                {
                    this.DosyaSilindiginde(this, new SonucArgs(this.Dosya, "Dosya olmadığından dolayı silinemedi.", DateTime.Now));
                    this.DosyaSilindiginde(this, new SonucArgs(this.Dosya, "Dosya olmadığından dolayı silinemedi xx.", DateTime.Now));
                }
                // this.DosyaSilindiginde?.Invoke(this, new SonucArgs(this.Dosya, "Dosya olmadığından silinemedi.", DateTime.Now));
            }

            Console.WriteLine("Dosya Sil Cagrildi..");
        }
    }
}

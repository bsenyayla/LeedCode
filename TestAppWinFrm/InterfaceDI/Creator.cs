using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppWinFrm.InterfaceDI
{
    internal class Creator
    {
        public static string str = "";
        private Creator() {
            str = "Yaratildi";
            Debug.WriteLine("Creator constractor");
        }

        public static Bildirim CreateBildirimInstance() {

            Debug.WriteLine("CreateBildirimInstance " + str);
            return new Bildirim(new SMS());
        }

        
    }
}

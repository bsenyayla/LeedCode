using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppWinFrm.InterfaceDI
{
    internal class SMS:IBildirim
    {


        public void Gonder()
        {
            Debug.WriteLine("SMS gonderildi..");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppWinFrm.InterfaceDI
{
    internal class Bildirim
    {
        IBildirim _bildirim;
        public Bildirim(IBildirim bildirim)
        { 
            _bildirim= bildirim;
        }

        public void Gonder()
        {
            _bildirim.Gonder();
        }
    }
}
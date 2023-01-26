using TestAppWinFrm.InterfaceDI;

namespace TestAppWinFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            Bildirim fnBildirim = InterfaceDI.Creator.CreateBildirimInstance();
            fnBildirim.Gonder();


            Bildirim fnBildirim2 = InterfaceDI.Creator.CreateBildirimInstance();
            fnBildirim2.Gonder();
        }
    }
}
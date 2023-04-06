using Newtonsoft.Json;
using System.Net.Http.Headers;
using TestAppWinFrm.InterfaceDI;

namespace TestAppWinFrm
{
    public partial class Form1 : Form
    {

        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:5087/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            Bildirim fnBildirim = InterfaceDI.Creator.CreateBildirimInstance();
            fnBildirim.Gonder();


            Bildirim fnBildirim2 = InterfaceDI.Creator.CreateBildirimInstance();
            fnBildirim2.Gonder();
        }

        

        private async void Call() {

            var response = await client.GetAsync("Test");

            textBox1.Text = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Assuming http://localhost:4354/api/ as BaseAddress 
            
            
        }

        private void btnCallWebApi_Click(object sender, EventArgs e)
        {
            Call();
        }


        enum Dayss
        {
            Pazarte,
            Sali,
            Ca
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                int re = 9 / c;
            }

            catch
            {

            }

            finally {
                int rr = (int)Dayss.Ca;

                string ddfg = "";
            }
            
        }
    }
}
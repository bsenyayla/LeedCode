namespace HomeWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Encapsulation => kapsulleme.cs
            Inheritence => KalitimClass,KalitimMirasVerenClass.cs
            Abstraction => SoyutlamaTelefon.cs,iphoneClass.cs,XiamiClass.cs
            Polymorphism => HayvanClass.cs,KediClass.cs,KopekClass.cs
             */


            //Kalıtım
            KalitimClass fnClass = new KalitimClass("Selçuk", "Döven");
            fnClass.Yaz();



            //Abstraction 
            iPhoneClass ip1 = new iPhoneClass();
            ip1.SendSms("34345");
            ip1.Camera();


            XiamiClass xiaPhone = new XiamiClass();
            xiaPhone.SendSms("334543");



            //Polymorphism
            HayvanClass hayvan1 = new HayvanClass();
            HayvanClass kedi = new KediClass();
            HayvanClass kopek = new KopekClass();


            hayvan1.hayvanSesi();
            kedi.hayvanSesi();
            kopek.hayvanSesi();
        }
    }
}
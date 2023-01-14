using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    /*
     Karmaşıklığı yönetmek için kullanılır. Nesnenin diğer tüm nesne türlerinden ayıran temel özelliklerini belirtir, böylece izleyicinin bakış açısından açıkça tanımlanmış bir kavramsal sınır sağlar. Nesne yönelimli programlamada, ayırma, ayrıntıları tanımlamaktan ziyade sınıflar veya yöntemler için temel görevleri tanımlamak anlamına gelir. Temel olarak, problemi çözmek için kullanılan yöntem öncelikle daha genel, daha basit ve soyut olmalıdır.
     */
    public abstract class SoyutlamaTelefon
    {

        public  void SendSms(String telefonNo) {
            Console.WriteLine("Sms gönderildi.");
        }


        public void AramaYap(String telefonNo)
        {
            Console.WriteLine("Arama yapılıyor.");
        }
    }
}

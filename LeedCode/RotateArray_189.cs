using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    public class RotateArray_189
    {
        Int32[] nums1 = new Int32[] { 1, 2, 3, 4, 5 };

        public RotateArray_189() {
            Console.WriteLine("<<== Rotate Array 189 ============================================================================>>");
            //SampleBigDatas.IntArrayLong, 54944


            Rotate(new Int32[] { 1,2 }, 5);
            Rotate_Way4(new Int32[] { 1,2 }, 5);

            //Rotate_Way2(nums, k);
        }


        /* ilk çözüm yolum . burada dizi sürekli tekrar ediyor. bu doğru değil 
           Şu senaryolara dikkat etmek gerekli dizi küçük tekrar büyük. [1,2] 5 yada [-1] 3

            onun yerine aslında yukarıdaki [1,2] lik dizi mod alınıp kalanı kadar dönse zaten aynısı oluyor .
            bizi boyu kadar bir kere dönersen rakam aynı olur aslında mod undan kalan kadar dönmeli dizi.

            bu mantık konulursa basit algo bile işimizi çözer .
            en base yol ,
            diziyi dömnemk yerine kaçıncı elemandan başlanacaksa ona gidip yeni dziye işem yapmak bir başka yol
            diziler kopyalanarak yol bulunabilir
            queue ve stack yolu ilede sonuca varılabilir.
         
        */
        private void Rotate(int[] nums, int k) {
            Console.WriteLine("Way 1 =============================================================================================");

            Stopwatch watch = new Stopwatch();     //  Ölçmek istediğimiz işlemin başlangıcına ekliyoruz.
            watch.Start(); //  Ölçmek istediğimiz işlemin başlangıcına ekliyoruz.

            //  Bu kısımda işlem olacak

            if (k <= 0) return;
            if (nums.Length == 0) return;

            Int32 prev = new Int32();
            Int32 tmp = new Int32();

            for (int j = 0; j < k; j++) {
                for (int i = 0; i < nums.Length; i++) {
                    tmp = nums[i];
                    nums[i] = prev;
                    prev = tmp;
                }
                nums[0] = prev;
            }

            watch.Stop();  //  Ölçmek istediğimiz işlemin sonuna ekliyoruz.
            Console.WriteLine("Way1 [" + String.Join(" , ", nums) + "] , " + k + " Süre :" + watch.Elapsed.Seconds + " sn");
            //[-2147483648,33,219,0,2147483647]
        }





        public void Rotate_Way2(int[] nums, int k) {
            Console.WriteLine("Way 2 =============================================================================================");
            Stopwatch watch = new Stopwatch();     //  Ölçmek istediğimiz işlemin başlangıcına ekliyoruz.
            watch.Start(); //  Ölçmek istediğimiz işlemin başlangıcına ekliyoruz.


            k = k % nums.Length;
            Int32[] buffer = new Int32[k];
            Array.Copy(nums, buffer, k);
            Array.Copy(nums, k, nums, 0, nums.Length - k);
            Array.Copy(buffer, 0, nums, nums.Length - k, k);

            Console.WriteLine("[" + String.Join(" , ", nums) + "]");

            watch.Stop();  //  Ölçmek istediğimiz işlemin sonuna ekliyoruz.
            Console.WriteLine("Rotate_Way2: {0}", watch.Elapsed.Seconds + " saniye"); //  Bağlantı süresini ekrana yazdırıyoruz.
        }


        public void Rotate_Way3() {
            //Queue<int> q = new Queue<int>(A);
            //Stack<int> s;
            //while (rotate > 0) {
            //    s = new Stack<int>(q);
            //    int x = s.Pop();
            //    s = new Stack<int>(s);
            //    s.Push(x);
            //    q = new Queue<int>(s);
            //    rotate--;
            //}
            //return q.ToArray();
        }


        public void Rotate_Way4(int[] nums, int k) {
            Stopwatch watch = new Stopwatch(); 
            watch.Start(); 

            if (k <= 0) return;
            if (nums.Length == 0) return;
            if (nums.Length < k) {
                k=k% nums.Length;
            }

            Int32[] numsRes = new Int32[nums.Length];
            Array.Copy(nums,numsRes,nums.Length);

            int count = 0;
            for (int i = nums.Length - k; i < nums.Length ; i++) {
                nums[count] = numsRes[i];
                count++;
            }

            for (int i =0 ; i < nums.Length - k; i++) {
                nums[count] = numsRes[i];
                count++;
            }

            watch.Stop();  
            Console.WriteLine("Way4 [" + String.Join(" , ", nums) + "] , " + k + " Süre :" + watch.Elapsed.Seconds + " sn");
            //[-2147483648,33,219,0,2147483647]

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class E_Linq
    {
        public E_Linq()
        {
            Console.WriteLine("Linq Kullanimi =========================================================================================================");

            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Find the Product of the elements:");

            double Average = Num.Aggregate((a, b) => a * b);
            Console.WriteLine("The Product is {0}", Average); //Output 362880 ((((((((1*2)*3)*4)*5)*6)*7)*8)*9)

            string[] charlist = { "a", "b", "c", "d" };
            var concta = charlist.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine("Concatenated String: {0}", concta); // Output a,b,c,d

            GroupBy();
        }

        class Student
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Location { get; set; }
        }

        public void GroupBy() {
            Console.WriteLine("\n\nGroup By Kullanimi =========================================================================================================");
            Console.WriteLine("Find the Product of the elements:");

            List<Student> objStudent = new List<Student>() {
                new Student() { Name = "Suresh Dasari", Gender = "Male",Location="TR" },
                new Student() { Name = "Rohini Alavala", Gender = "Female", Location="USA" },
                new Student() { Name = "Praveen Alavala", Gender = "Male",Location="USA" },
                new Student() { Name = "Sateesh Alavala", Gender = "Male", Location ="TR"},
                new Student() { Name = "Madhav Sai", Gender = "Male", Location="USA"}
            };

            /* var student = from std in objStudent
               group std by std.Location; */

            var student = objStudent.GroupBy(x => x.Location);

            foreach (var sitem in student)
            {
                Console.WriteLine("Key:" + sitem.Key + " Count:" + sitem.Count());
                
                foreach (var stud in sitem)
                {
                    Console.WriteLine("StudentName:" + stud.Name + "\t" + stud.Location);
                }
            }
        }


        public void DescendingString(string str)
        {
            string[] charlist = { "a", "b", "c", "d" };
            var concta = charlist.Aggregate((a, b) => a + '*' + b);

            var res2 = charlist.OrderByDescending(x => x).Aggregate((a, b) => a + " , " + b);

            Console.WriteLine("Concatenated String: {0}", concta); // Output a,b,c,d

            Console.WriteLine("Reverse Aggregate String: {0}", res2); // Output a,b,c,d
        }


        //Bu fonksiyon datanin dizinin icine bakmaz oldugu gibi ters cevirir.
        public void ReverseSample()
        {
            int[] arrInt = new int[] { 1, 8, 3, 5, 9 };

            Console.WriteLine(" Sonuc: " + String.Join(",",

                arrInt.Reverse()
                ));

            try { 
            }

            catch { 
            
            }

            finally {
                Console.WriteLine();
            }

        }

    }
}
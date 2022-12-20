using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the start point");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the end point");
            int n2= int.Parse(Console.ReadLine());

            int round = 0;
            // يعد عدد المرات لل الرقم الي بتحقق منه لو طلع 2 اذا دا رقم اولي غير كده لا ( round )الرقم الاولي هيقبل القسمه علي نفسه وعلي الواحد اذا اي رقم خلال الحلقه  هيحقق الشرط دا مرتين ف انا هستخدم المتغير

            for (int i = n1; i <= n2; i++)
           {
                for (int j = 1; j <= i; j++) {
                if(i%j==0)
                        round++;
                
                }
                if (round == 2)
                {
                    Console.WriteLine(i);
                    round = 0;
                }
                else
                {
                    round = 0;
                }

            }













            Console.ReadKey();
        }
    }
}

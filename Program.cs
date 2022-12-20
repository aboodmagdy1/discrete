using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program



    {
        public static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number) return true;

            return false;



        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the start point");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the end point");
            int n2 = int.Parse(Console.ReadLine());



            for (int i = n1; i <= n2; i++)
            {

                if (IsPerfect(i))
                    Console.WriteLine(i);

            }


            Console.ReadKey();

        }



    }
}

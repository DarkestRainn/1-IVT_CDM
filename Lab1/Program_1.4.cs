using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_low
{
    class Program
    {
        static void Main(string[] args)
        {
            long g = 1, znam = 1;
            Console.WriteLine("Введите n: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= k; i++)
            {
                long f = Factor(i);
                znam *= f;
            }
            long result = Factor(N)/znam;
            Console.WriteLine("Ответ: " + result);
            Console.ReadLine();
        }

        public static long Factor(int N)
        {
            long factorial = 1;
            for (long i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

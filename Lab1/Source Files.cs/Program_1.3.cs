using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            long znam = Factor(N-k) * Factor(k);
            long result = Factor(N) / znam;
            Console.WriteLine("Ответ: " + result);
            Console.ReadLine();
        }
        public static long Factor (int N){
            long factorial = 1;
            for (long i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

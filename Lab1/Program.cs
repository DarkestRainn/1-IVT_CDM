using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        private static int op;

        static void Main(string[] args)
        {
            do {
                Console.WriteLine("Что вы хотите вычислить?\n" + "1 - Число размещений без повторений A\n" +
                "2 - Число перестановок P\n" + "3 - Число сочетаний C\n" + "4 - Число перестановок с повторениями P(n1,n2,...,nk)\n"
                + "0 - Выход из программы");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case 1:
                        Console.WriteLine("Введите n: ");
                        int N1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите k: ");
                        int k1 = Convert.ToInt32(Console.ReadLine());
                        long result1 = Factor(N1) / Factor(N1 - k1);
                        Console.WriteLine("Ответ: " + result1);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите n: ");
                        int N2 = Convert.ToInt32(Console.ReadLine());
                        long result2 = Factor(N2);
                        Console.WriteLine("Ответ: " + result2);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Введите n: ");
                        int N3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите k: ");
                        int k3 = Convert.ToInt32(Console.ReadLine());
                        long znam3 = Factor(N3 - k3) * Factor(k3);
                        long result = Factor(N3) / znam3;
                        Console.WriteLine("Ответ: " + result);
                        Console.ReadLine();
                        break;
                    case 4:
                        long znam4 = 1;
                        Console.WriteLine("Введите n: ");
                        int N4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите k: ");
                        int k4 = Convert.ToInt32(Console.ReadLine());
                        for (int i4 = 2; i4 <= k4; i4++) {
                            long f4 = Factor(i4);
                            znam4 *= f4;
                        }
                        long result4 = Factor(N4) / znam4;
                        Console.WriteLine("Ответ: " + result4);
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует!");
                        break;
                }
            } while (op != 0);
        }

        public static long Factor(int N)
        {
            long factorial = 1;
            for (long i = 1; i <= N; i++) {
                factorial *= i;
            }
            return factorial;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double soma = 0;
            double x;
            Console.WriteLine("Informe o intervalo de valores para série : \n1 * ^x + 2 * x ^ 2 + 3 * x ^ 3 + 4 * x ^ 4 + 5 * x ^ 5 + … +n * x ^ n");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + "*x^" + i);
                if (i < num)
                    Console.Write(" + ");
                x = (double)i;
                soma = soma + (i * Math.Pow(x, x));
            }

            Console.WriteLine($"\nA soma da série é : {soma}");
            Console.ReadKey();
        }
    }
}

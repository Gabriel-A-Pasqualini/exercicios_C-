using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOnze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                double p;
                double area;
                if (verificaSeTrianguloExiste(a, b, c))
                {
                    p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    Console.WriteLine(area);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Não existe triângulo com os lados informados");
                    Console.ReadKey();
                }
            }
        }
        private static bool verificaSeTrianguloExiste(double a, double b, double c)
        {
            double bc = Math.Abs(b - c);
            double ac = Math.Abs(a - c);
            double ab = Math.Abs(a - b);
 
            bool cond1 = false;
            bool cond2 = false;
            bool cond3 = false;

            if (bc < a && a < b + c)
            {
                cond1 = true;
            }
            if (ac < b && b < a + c)
            {
                cond2 = true;
            }
            if (ab < c && c < a + b)
            {
                cond3 = true;
            }
            if (cond1 && cond2 && cond3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

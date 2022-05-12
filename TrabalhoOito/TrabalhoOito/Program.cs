using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOito
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int num, num2;
            int  i = 2;
            while (true)
            {
                Console.WriteLine("Entre com dois numeros: ");
                num = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (num > num2)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine(num2);
                }

                while (i < num)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("\nEste número é um número Composto.");
                        break;
                    }
                    i++;
                }

                if (i == num)
                {
                    Console.WriteLine("\nEste número é um número Primo.");
                }
                if (num == 0 || num == 1)
                {
                    Console.WriteLine("\nEste número não é composto nem primo.");
                }
            Console.WriteLine();
            }
        }
    }
}

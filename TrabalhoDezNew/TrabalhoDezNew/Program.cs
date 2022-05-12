using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDezNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int numInt = int.Parse(num);
            int size = num.Length;
            int soma = 0;
            int aux;
            for (int i = 1; i <= size; i++)
            {
                aux = numInt % 10;
                numInt = numInt / 10;
                Console.Write(aux);       
                soma = soma + aux;
            }
            Console.WriteLine("\n"+ soma);
        }
    }
}

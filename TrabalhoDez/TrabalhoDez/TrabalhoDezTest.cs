using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabalhoDez
{
    internal class TrabalhoDezTest
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int size = num.Length;
            int [] arr = new int[size];
            int soma = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(num[i].ToString());
                soma = soma + arr[i]; 
            }
            Console.WriteLine("arr: "+"[{0}]", string.Join(", ", arr));
            Console.WriteLine(soma);
        }
    }
}

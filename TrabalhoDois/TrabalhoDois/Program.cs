using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

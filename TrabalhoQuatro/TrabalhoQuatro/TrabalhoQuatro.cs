using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoQuatro
{
    internal class TrabalhoQuatro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da Matrix: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matrix Identidade");
           
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i==j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }            
    }
}

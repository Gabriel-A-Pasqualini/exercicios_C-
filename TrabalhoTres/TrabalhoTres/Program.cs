using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int i = 0;
            do
            {
                Console.Write(i);
                Console.Write(" ");
                 ch = (char)i;
                Console.WriteLine(ch);
                i++;
            } while (i <= 255);
            Console.ReadKey();
        }
    }
}

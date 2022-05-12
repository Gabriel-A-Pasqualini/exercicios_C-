using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSete
{
    internal class TrabalhoSete
    {
        static void Main(string[] args)
        {
            int aux;
            Console.WriteLine("Array's size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [size];

            Console.WriteLine("Input values: ");
   
            for (int i = 0; i < size; i++)
            {      
                 arr [i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Before: "+"[{0}]", string.Join(", ", arr));
            
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size-1; j++)
                {
                    if(arr [j] > arr[j+1])
                    {
                        aux = arr [j];
                        arr[j] = arr [j+1];
                        arr [j+1] = aux;
                        Console.WriteLine("[{0}]", string.Join(", ", arr));
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("After: " + "[{0}]", string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}

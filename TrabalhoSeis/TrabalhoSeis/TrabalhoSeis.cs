using System;

namespace TrabalhoSeis
{
    internal class TrabalhoSeis
    {
        static void Main(string[] args)
        {
            int valor;
            string temp;
            char escolha;
            double centimetro, litros, Kilometro;

            Console.WriteLine("Informe um valor inteiro para converter :");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n Pressione uma das opções dadas : \n P -> converte de Polegadas para Centímetros.\n G -> converte de Galões para Litros.\n M -> converte de Milas para Kilômetros");
            Console.WriteLine(" C -> converte de Centímetros para Polegadas.\n L -> converte de Litros para Galões.\n K -> converte de Kilômetros para Milhas");


            temp = Console.ReadLine().ToString().ToUpper();
            escolha = Convert.ToChar(temp);

            switch (escolha)
            {
                case 'P':
                    centimetro = valor / 0.3937;                      
                    Console.WriteLine("\n\n" + valor + " Polegadas são " + centimetro + " centímetros (cm) ");
                    break;

                case 'C':
                    centimetro = valor * 0.3937;
                    Console.WriteLine("\n\n" + valor + " Centímetros (cm) são " + centimetro + " polegadas ");
                    break;

                case 'G':
                    litros = valor * 3.78;                             
                    Console.WriteLine("\n\n" + valor + " Galões são " + litros + " litros (l) ");
                    break;

                case 'L':
                    litros = valor / 3.78;
                    Console.WriteLine("\n\n" + valor + " Litros (l)" + litros + " galões ");
                    break;

                case 'M':
                    Kilometro = valor * 1.60;                         
                    Console.WriteLine("\n\n" + valor + " Milhas são " + Kilometro + " Kilometros (Km) ");
                    break;

                case 'K':
                    Kilometro = valor / 1.60;
                    Console.WriteLine("\n\n" + valor + " Kilometros (Km) " + Kilometro + "  Milhas ");
                    break;

                default:
                    Console.WriteLine("Opção Inválida. Informe uma das opções oferecida:  P , G ou M ");
                    break;
            }
            Console.ReadKey();
        }
    }
}

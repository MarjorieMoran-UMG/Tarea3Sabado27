using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("----------PAR O IMPAR----------");
            Console.WriteLine("Ingrese el número: \t \t ");
            numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("------El número es PAR------");
            }
            else
            {
                Console.WriteLine("------El número es IMPAR------");
            }
        }
    }
}
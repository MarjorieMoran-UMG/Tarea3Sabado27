using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            long fact = 1;
            Console.WriteLine("-----------------PROGRAMA DE FACTORIAL-----------------");
            Console.WriteLine("Ingrese el número a calcular: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("\n" + num + "! = 1");
            for (i=2; i<=num; i++)
            {
                fact *= i;
                Console.Write("\u00D7" + i);
            }
            Console.WriteLine("=" + fact);
        }
    }
}

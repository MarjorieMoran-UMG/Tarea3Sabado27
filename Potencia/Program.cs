using System;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, potencia, i, resultado=1;

            Console.WriteLine("------------------PROGRAMA DE POTENCIA--------------------");
            Console.WriteLine("Ingrese el numero a calcular: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese a que potencia desea elevarlo: ");
            potencia = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= potencia; i++)
            {
                resultado = resultado * num;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("La potencia de su numero es: " + resultado);
        }
    }
}

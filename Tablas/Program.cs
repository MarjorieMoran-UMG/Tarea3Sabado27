using System;

namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, x, res;
            Console.WriteLine("--------------------------TABLA DE MULTIPLICAR----------------------");
            Console.Write("Ingrese el numero del que desea visualizar su tabla de multiplicar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La tabla de multiplicar dek número que ingreso es la siguiente: \n");
            for (x = 1; x <= 10; x++)
            {
                res = numero * x;
                Console.WriteLine(x + "x" + numero + "=" + res);
            }
        }
    }
}

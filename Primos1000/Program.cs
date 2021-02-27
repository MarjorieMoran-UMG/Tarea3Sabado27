using System;

namespace Primos1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2, c, contador = 0;

            Console.WriteLine("--------------PROGRAMA DE NUMEROS PRIMOS DEL 1 AL 1000--------------");
            Console.WriteLine("Todos los números que a continuación se presentan son números primos");
            while (num <= 1000)
            {
                for (c = 1; c <= num; c++)
                {
                    if (num % c == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("El número: \t" + num);
                }
                contador = 0;
                num++;
            }
        }
    }
}

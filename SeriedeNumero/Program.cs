using System;

namespace SeriedeNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, a, num;
            Console.WriteLine("-----------------PROGRAMA DE SERIE DE UN NUMERO-------------------");
            Console.Write("Ingrese un número: \t");
            num = int.Parse(Console.ReadLine());
            d = 0;
            m = 1;
            for (int i = 0; i < num; i++);
            {
                a = d;
                d = m;
                m = a + d;
                Console.Write("{0}", a);
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace DiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("--------------------DÍA DE LA SEMANA-------------------");
            Console.WriteLine("Por favor ingrese un número del 1 al 7: \t ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Este número corresponde al día: Domingo");
            }
            if (num == 2)
            {
                Console.WriteLine("Este número corresponde al día: Lunes");
            }
            if (num == 3)
            {
                Console.WriteLine("Este número corresponde al día: Martes");
            }
            if (num == 4)
            {
                Console.WriteLine("Este número corresponde al día: Miércoles");
            }
            if (num == 5)
            {
                Console.WriteLine("Este número corresponde al día: Jueves");
            }
            if (num == 6)
            {
                Console.WriteLine("Este número corresponde al día: Viernes");
            }
            if (num == 7)
            {
                Console.WriteLine("Este número corresponde al día: Sábado");
            }
        }
    }
}
       
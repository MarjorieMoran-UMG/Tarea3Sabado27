using System;

namespace GradosyRadianes
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            const double pi = 3.1416;
            double num, resultado;
            Console.WriteLine("------------------GRADOS Y RADIANES-------------------");
            Console.WriteLine("1 - De grados a radianes");
            Console.WriteLine("2 - De radianes a grados");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("La opción que desea elegir es: \t \t");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.Write("Ingrese la cantidad que desea convertir de grados a radiantes: \t");
                        num = float.Parse(Console.ReadLine());
                        resultado = num * pi / 180;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
                case 2:
                    {

                        Console.Write("Ingrese la cantidad que desea convertir de radiantes a grados: \t");
                        num = float.Parse(Console.ReadLine());
                        resultado = num * 180 / pi;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
            }
        }
    }
}

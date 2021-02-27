using System;

namespace PolígonoRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion,lados;
            double longitud, perimetro, apotema, area;

            Console.WriteLine("---------------------------POLÍGONO REGULAR--------------------------");
            Console.WriteLine("---------------------------------MENÚ--------------------------------");
            Console.WriteLine("Ingrese el número de la opción que desea calcular:");
            Console.WriteLine("1. Perímetro");
            Console.WriteLine("2. Área");
            Console.WriteLine("3. Perímetro y Área");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("La opción que desea elegir es: \t \t \t ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el número de lados del polígono: \t \t");
                    lados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la longitud de un lado del polígono: \t");
                    longitud = Convert.ToDouble(Console.ReadLine());
                    perimetro = (lados * longitud);
                    Console.WriteLine("El Perímetro del polígono es de:" + (perimetro));
                }
                if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el número de lados del polígono: \t \t");
                    lados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la longitud de un lado del polígono: \t");
                    longitud = Convert.ToDouble(Console.ReadLine());
                    perimetro = (lados * longitud);
                    Console.WriteLine("Ingrese el apotema del polígono: \t \t");
                    apotema = Convert.ToDouble(Console.ReadLine());
                    area = (perimetro * apotema) / 2;
                    Console.WriteLine("El Área del polígono es de:" + (area));
                }
                if (opcion == 3)
                {
                    Console.WriteLine("Ingrese el número de lados del polígono: \t \t");
                    lados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la longitud de un lado del polígono: \t");
                    longitud = Convert.ToDouble(Console.ReadLine());
                    perimetro = (lados * longitud);
                    Console.WriteLine("Ingrese el apotema del polígono: \t \t");
                    apotema = Convert.ToDouble(Console.ReadLine());
                    area = (perimetro * apotema) / 2;
                    Console.WriteLine("El Perímetro del polígono es de:" + (perimetro));
                    Console.WriteLine("El Área del polígono es de:" + (area));
                }
        }
    }
}

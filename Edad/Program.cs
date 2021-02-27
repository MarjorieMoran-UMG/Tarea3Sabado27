using System;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int numpersonas, i, mayor = 0, menor = 0;
            Console.WriteLine("-------------------PROGRAMA DE PROMEDIO DE EDADES---------------------");
            Console.Write("Ingrese aquí el número de personas a promediar: \t");
            numpersonas = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[numpersonas + 1];
            for (i = 1; i <= numpersonas; i++)
            {
                Console.Write("Ingrese la edad de la persona: \t");
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }
            mayor = edades[1];
            menor = edades[1];
            for (i = 1; i <= numpersonas; i++)
            {
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                }
                else if (edades[i] < menor)
                {
                    menor = edades[i];
                }
            }

            Console.WriteLine("La persona con la mayor edad tiene  " + mayor);
            Console.WriteLine("La persona con la menor edad tiene  " + menor);
        }
    }
}

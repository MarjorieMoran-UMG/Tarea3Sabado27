using System;

namespace Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double precio, impuesto;
            const double iva = 0.12;

            Console.WriteLine("----------------------------SUPER FAMILIAR---------------------------");
            Console.WriteLine("----------------------IMPUESTOS SOBRE LOS PRODUCTOS------------------");
            Console.WriteLine("Ingrese el número al que pertenece su producto:");
            Console.WriteLine("1.   Alimentos");
            Console.WriteLine("2.   Abarrotes");
            Console.WriteLine("3.   Electrodomésticos");
            Console.WriteLine("4.   Artículos de Limpieza");
            Console.WriteLine("5.   Útiles");
            Console.WriteLine("6.   Medicina");
            Console.WriteLine("7.   Aparatos Electrónicos");
            Console.WriteLine("8.   Ropa");
            Console.WriteLine("9.   Accesorios");
            Console.WriteLine("10.  Herramientas");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Su producto pertenece a la opción: \t \t \t ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 3)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 4)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 5)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 6)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * 0.00);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto), "(Este producto está excento)");
            }
            if (opcion == 7)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 8)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 9)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
            if (opcion == 10)
            {
                Console.WriteLine("Ingrese el precio de su producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                impuesto = (precio * iva);
                Console.WriteLine("El Impuesto de su Producto es de:" + (impuesto));
            }
        }
    }
}



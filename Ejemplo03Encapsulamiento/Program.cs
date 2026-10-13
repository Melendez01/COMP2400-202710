using System;

namespace Ejemplo03Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("Laptop", 850);

            Console.WriteLine("Producto: " + producto1.Nombre);
            Console.WriteLine("Precio: $ " + producto1.Precio);

            Console.WriteLine();

            producto1.Nombre = "Tablet";
            producto1.Precio = 500;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Producto: " + producto1.Nombre);
            Console.WriteLine("Precio: $ " + producto1.Precio);

        }
    }
}

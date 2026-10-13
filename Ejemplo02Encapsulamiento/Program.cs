using System;

namespace Ejemplo02Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear el objeto

            Persona persona1 = new Persona("Joe", 30);

            //persona1.Nombre = "Ana";
            //persona1.edad = 25;

            //persona1.Nombre = "Joe";
            persona1.Edad = -18;

            Console.WriteLine("Nombre: " + persona1.Nombre);
            Console.WriteLine("Edad: " + persona1.Edad);



        }
    }
}
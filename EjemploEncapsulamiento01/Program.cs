using System;

namespace EjemploEncapsulamiento01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            Persona persona1 = new Persona("Joe", 28);

            //Asignar valores
            //persona1.Nombre = "Ana";
            //persona1.Edad = -25;

            //Mostrar información
            Console.WriteLine("Nombre: " + persona1.Nombre ?? "");
            Console.WriteLine("Edad: " + persona1.Edad ?? "");

            persona1.Edad = 25;
            Console.WriteLine(persona1.Edad);

            persona1.Edad = -10;
            Console.WriteLine(persona1.Edad);


        }
    }
}
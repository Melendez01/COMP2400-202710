using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase hija
            Perro perro1 = new Perro();

            // Asignar valores
            perro1.Nombre = "Max";
            perro1.Edad = 3;
            perro1.Raza = "Labrador";

            // Llamar los métodos
            perro1.MostrarInformacion();
            perro1.MostrarRaza();
        }
    }
}











using System;

namespace Practica_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Estudiantes ===");


            // OBJETO 1
            // Se crea utilizando valores escritos directamente
            // en el constructor con parámetros
            Estudiante estudiante1 =
                new Estudiante(
                    "Ana López",
                    "A001",
                    "Ciencias de Computadoras",
                    3.75
                );


            // OBJETO 2
            // Primero se solicitan los datos al usuario
            Console.WriteLine("\nIngrese los datos del Estudiante 2");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Número de estudiante: ");
            string numero = Console.ReadLine() ?? "";

            Console.Write("Programa académico: ");
            string programa = Console.ReadLine() ?? "";

            Console.Write("Promedio: ");
            double promedio = Convert.ToDouble(Console.ReadLine());

            // Se crea el objeto utilizando las variables
            Estudiante estudiante2 = new Estudiante(nombre, numero, programa, promedio);


            // OBJETO 3
            // Se crea utilizando el constructor vacío
            Estudiante estudiante3 = new Estudiante();


            // Mostrar los datos de los primeros dos objetos
            Console.WriteLine("\n--- Estudiante 1 ---");
            estudiante1.MostrarInformacion();

            Console.WriteLine("\n--- Estudiante 2 ---");
            estudiante2.MostrarInformacion();


            // Mostrar el objeto 3 antes de cambiar sus valores
            Console.WriteLine("\n--- Estudiante 3: valores iniciales ---");
            estudiante3.MostrarInformacion();


            // Cambiar los datos del objeto 3
            Console.WriteLine("\nIngrese nuevos datos para el Estudiante 3");

            Console.Write("Nombre: ");
            estudiante3.nombre = Console.ReadLine() ?? "";

            Console.Write("Número de estudiante: ");
            estudiante3.numeroEstudiante = Console.ReadLine() ?? "";

            Console.Write("Programa académico: ");
            estudiante3.programa = Console.ReadLine() ?? "";

            Console.Write("Promedio: ");
            estudiante3.promedio =
            Convert.ToDouble(Console.ReadLine());


            // Mostrar nuevamente el objeto 3
            Console.WriteLine("\n--- Estudiante 3: datos actualizados ---");
            estudiante3.MostrarInformacion();
        }
    }
}

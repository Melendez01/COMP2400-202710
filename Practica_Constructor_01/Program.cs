using System;

namespace Practica_Constructor_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Estudiantes ===");

            //Crear el primer objeto
            Estudiante estudiante1 = new Estudiante("Ana López", "A001", "Ciencias de Computadoras", 3.75);

            //Asignar valores directamente
            //estudiante1.nombre = "Ana López";
            //estudiante1.numeroEstudiante = "A001";
            //estudiante1.programa = "Ciencias de Computadoras";
            //estudiante1.promedio = 3.75;


            //Solicitar los datos al usuario

            Console.WriteLine("\nIngrese los datos del Estudiante 2");

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine() ??""; //??"" se utiliza para evitar que el programa asigne un valor nulo

            Console.Write("Ingrese el número del estudiante: ");
            string numero = Console.ReadLine() ??""; 

            Console.Write("Ingrese el programa académico: ");
            string programa = Console.ReadLine() ?? "";

            Console.Write("Ingrese el promedio: ");
            double promedio = Convert.ToDouble(Console.ReadLine()); 

            //Crear el segundo objeto

            Estudiante estudiante2 = new Estudiante(nombre, numero, programa, promedio);

            //Mostrar la información de los objetos
            Console.WriteLine("\n---Estudiante 1 ---");
            estudiante1.MostrarInformacion();

            Console.WriteLine("\n---Estudiante 2 ---");
            estudiante2.MostrarInformacion();


            //Objeto 3 - constructor vacío
            Estudiante estudiante3 = new Estudiante();

            //Mostrar valores iniciales
            Console.WriteLine("\n--- Estudiante 3: valores iniciales");
            estudiante3.MostrarInformacion();

            //Cambiar los datos del objeto 3
            Console.WriteLine("\nIngrese nuevos datos para el Etudiante 3");

            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante3.nombre = Console.ReadLine() ??""; //??"" se utiliza para evitar que el programa asigne un valor nulo

            Console.Write("Ingrese el número del estudiante: ");
            estudiante3.numeroEstudiante = Console.ReadLine() ??""; 

            Console.Write("Ingrese el programa académico: ");
            estudiante3.programa = Console.ReadLine() ?? "";

            Console.Write("Ingrese el promedio: ");
            estudiante3.promedio = Convert.ToDouble(Console.ReadLine()); 


            // Mostrar datos actualizados
            Console.WriteLine("\n--- Estudiante 3: datos actualizados ---");
            estudiante3.MostrarInformacion();

        }
    }
}

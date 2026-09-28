using System;

namespace Practica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear el primer objeto
            Estudiante estudiante1 = new Estudiante();

            //Asignar valores directamente
            estudiante1.nombre = "Ana López";
            estudiante1.numeroEstudiante = "A001";
            estudiante1.programa = "Ciencias de Computadoras";
            estudiante1.promedio = 3.75;


            //Crear el segundo objeto

            Estudiante estudiante2 = new Estudiante();

            //Solicitar los datos al usuario

            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante2.nombre = Console.ReadLine() ??""; //??"" se utiliza para evitar que el programa asigne un valor nulo

            Console.Write("Ingrese el número del estudiante: ");
            estudiante2.numeroEstudiante = Console.ReadLine() ??""; 

            Console.Write("Ingrese el programa académico: ");
            estudiante2.programa = Console.ReadLine() ?? "";

            Console.Write("Ingrese el promedio: ");
            estudiante2.promedio = Convert.ToDouble(Console.ReadLine()); 

            //Mostrar la información de los objetos
            Console.WriteLine("\n---Estudiante 1 ---");
            estudiante1.MostrarInformacion();

            Console.WriteLine("\n---Estudiante 2 ---");
            estudiante2.MostrarInformacion();


        }
    }
}

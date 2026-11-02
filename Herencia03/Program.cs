using System;

namespace Herencia03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona{ Nombre = "Ana", Edad = 35  };
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Carlos",  Edad = 20 ,  Carrera = "Computadoras"
            };

            Profesor profesor1 = new Profesor
            {
                Nombre = "Maria", Edad = 42, Especialidad = "Programación"

            };

            persona1.MostrarInformacion();
            estudiante1.MostrarInformacion();  //Metodo heredado
            estudiante1.MostrarCarrera();    //Metodo Propio
            profesor1.MostrarInformacion();
            profesor1.MostrarEspecialidad();

        }
    }
}
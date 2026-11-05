using System;

namespace Herencia_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear los objetos
            Perro rex = new Perro
            {
                Nombre = "Rex",
                Edad = 5,
                Dueno = "Juan",
                Raza = "Labrador"
            };

            Gato felix = new Gato
            {
                Nombre = "Felix",
                Edad = 3,
                Dueno = "María",
                ColorPelaje = "Negro"
            };

            Tortuga tina = new Tortuga
            {
                Nombre = "Tina",
                Edad = 10,
                Dueno = "Pedro",
                TipoCaparazon = "Duro"
            };

            // Mostrar los sonidos
            rex.EmitirSonido();
            felix.EmitirSonido();
            tina.EmitirSonido();

            // Mostrar la información
            rex.MostrarInformacion();
            felix.MostrarInformacion();
            tina.MostrarInformacion();
        }
    }
        
}


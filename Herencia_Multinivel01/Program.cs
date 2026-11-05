using System;

namespace Herencia_Multinivel01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto
            Gerente gerente1 = new Gerente();

            gerente1.Nombre = "Ana";
            gerente1.Salario = 2500;
            gerente1.Departamento = "Tecnología";

            Console.WriteLine(gerente1.Nombre);
            Console.WriteLine(gerente1.Salario);
            Console.WriteLine(gerente1.Departamento);
        }
    }
}

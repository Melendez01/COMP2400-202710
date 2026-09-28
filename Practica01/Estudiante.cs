class Estudiante
{
    //Atributos

    public string nombre = " ";
    public string numeroEstudiante = " ";
    public string programa = " ";
    public double promedio;


    //Método para mostrar información

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Número de estudiante: " + numeroEstudiante);
        Console.WriteLine("Programa académico: " + programa);
        Console.WriteLine("Promedio: " + promedio);

        Console.WriteLine();
    }

}
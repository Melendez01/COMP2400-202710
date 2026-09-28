class Estudiante
{
    //Atributos

    public string nombre = " ";
    public string numeroEstudiante = " ";
    public string programa = " ";
    public double promedio;

    //Constructor vacio
    public Estudiante()
    {
        nombre = "Sin nombre";
        numeroEstudiante = "Sin número";
        programa = "No definido";
        promedio = 0;
    }

    //Constructor con parametros
    public Estudiante(string nombreInicial, string numeroInicial, string programaInicial, double promedioInicial)
    {
        nombre = nombreInicial;
        numeroEstudiante = numeroInicial;
        programa = programaInicial;
        promedio = promedioInicial;
    }


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
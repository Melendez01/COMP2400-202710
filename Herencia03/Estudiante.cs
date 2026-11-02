public class Estudiante : Persona
{
    public string Carrera {get; set; } = " ";

    public void MostrarCarrera()
    {
        Console.WriteLine($"Carrera: {Carrera}");
    }
    
}
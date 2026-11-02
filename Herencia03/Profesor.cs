public class Profesor : Persona
{
    public string Especialidad {get;  set; } = " ";

    public void MostrarEspecialidad()
    {
        Console.WriteLine($"Especialidad: {Especialidad}");
    }
}
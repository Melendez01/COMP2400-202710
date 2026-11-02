public class Animal
{
    // Propiedades de la clase padre
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }

    // Método de la clase padre
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
    }
}
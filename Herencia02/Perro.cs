// La clase Perro hereda de Animal
public class Perro : Animal
{
    // Propiedad de la clase hija
    public string Raza { get; set; } = "";

    // Método de la clase hija
    public void MostrarRaza()
    {
        Console.WriteLine($"Raza: {Raza}");
    }
}
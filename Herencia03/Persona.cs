public class Persona
{
    //Atributos
    public string Nombre {get; set;} = " ";
    public int Edad {get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine ($"Nombre: {Nombre}, Edad: {Edad}");
    }
}
public class Persona
{
    private string nombre;
    private int edad;

    //Metodo Constructor

    public Persona (string nombreInicial, int edadInicial)
    {
        nombre = nombreInicial;
        edad = edadInicial;
    }
    public string Nombre
    {
        get { return nombre; } //Devuelve el valor de nombre
        set { nombre = value; } //Asigna un nuevo valor a nombre
    }

    public int Edad
    {
        get { return edad; } //Devuelve el valor de edad
        set
        {
            if (value > 0)
            {
                edad = value;

            }
            else
            {
                Console.WriteLine("La edad debe ser mayor que 0");
            }
        } 
    }

}
public class Producto
{
    //Atributos privados
    private string nombre;
    private double precio;


    //Metodo Constructor
    public Producto (string nombreInicial, double precioInicial)
    {
        nombre = nombreInicial;
        precio = precioInicial;

    }

    //Encapsulamiento Métodos para acceder a los atributos privados

    public string Nombre
    {
        get {return nombre; }
        set { nombre = value; }
    }

    public double Precio
    {
        get { return precio; }
        set
        {
            if (value >= 0)

            {
                precio = value;
            }
        }
    }
}
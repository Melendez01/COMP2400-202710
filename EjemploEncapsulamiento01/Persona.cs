namespace EjemploEncapsulamiento01
{
    public class Persona
    {
        private string nombre;
        private int edad;

        // Nombre con N mayúscula es la propiedad. 
        // nombre con n minúscula es el atributo privado.

        //Constructor
        public Persona(string nombreInicial, int edadInicial)
        {
            nombre = nombreInicial;
            edad = edadInicial;
        }

        public string Nombre
        {
            get {return nombre;} // Devuelve el valor de nombre
            set {nombre = value;} // Asigna un nuevo valor a nombre

        }

        /*public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        */
        public int Edad
        {
            get { return edad; } // Devuelve el valor de edad

            set
            {
                if (value > 0)   //valida que edad sea mayor que 0
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("La edad debe ser mayor que 0.");
                }
                    
            }
        }



    }
    
}

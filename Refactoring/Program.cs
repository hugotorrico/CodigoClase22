// See https://aka.ms/new-console-template for more information


#region checkNulls
//Add null checks for all parameters
void MostrarDatos(string nombres, string apellidos, string direccion)
{
    if (nombres is null)
    {
        throw new ArgumentNullException(nameof(nombres));
    }

    if (apellidos is null)
    {
        throw new ArgumentNullException(nameof(apellidos));
    }

    if (string.IsNullOrWhiteSpace(direccion))
    {
        throw new ArgumentException($"\"{nameof(direccion)}\" no puede ser NULL ni un espacio en blanco.", nameof(direccion));
    }

    Console.WriteLine(nombres);
    Console.WriteLine(apellidos);
}
#endregion


MostrarDatos("Hugo", "Torrico", "Santa Anita");

CalcularArea();

Console.Read();



#region anonymusType


//Convert anonymous type to class
void CrearPersona()
{

    var persona = new Persona("Hugo", "Torrico", 36);

    // Objetos anónimos
    var persona2 = new { Nombre = "Sergio", Apellido = "Valle", Edad = 25 };

    Console.WriteLine(persona.Edad);
    Console.WriteLine(persona.Nombre);

}

static void CalcularArea()
{
    double base1;
    double altura;
    double area;

    base1 = 10;
    altura = 20;
    area = base1 * altura;

    Console.WriteLine(area);
}

class Persona
{
    public string Nombre { get; }
    public string Apellido { get; }
    public int Edad { get; }

    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

    public override bool Equals(object? obj)
    {
        return obj is Persona other &&
               Nombre == other.Nombre &&
               Apellido == other.Apellido &&
               Edad == other.Edad;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nombre, Apellido, Edad);
    }
}
#endregion
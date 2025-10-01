namespace Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan Pérez";
            persona.DNI = "12345678A";
            persona.ComunicarIncidencia("Estoy enfermo.");
        }
    }
}
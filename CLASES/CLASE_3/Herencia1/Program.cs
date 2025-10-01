namespace Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Juan Pérez");
            persona.FechaNacimiento = new DateTime(1996, 8, 1);
            persona.DNI = "12345678A";
            persona.ComunicarIncidencia("Estoy enfermo.");

            Empleado empleado = new Empleado("José López", 78);
            empleado.FechaNacimiento = new DateTime(2004, 3, 22);
            empleado.DNI = "87654321Z";
            empleado.ComunicarIncidencia("Estoy enfermo.");
            Console.WriteLine($"Empleado: {empleado.Nombre}, ID: {empleado.IdEmpleado}");
            Console.WriteLine(empleado.ToString());

            Persona empleado2 = empleado;
            empleado2.ComunicarIncidencia("Estoy enfermo otra vez");

            object objEmpleado = empleado;
            Console.WriteLine(objEmpleado.ToString());

            Console.WriteLine("Fin del programa.");
        }
    }
}
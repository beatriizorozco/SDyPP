namespace OO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo = new Vehiculo();
            miVehiculo.Marca = "Seat";
            Console.WriteLine(miVehiculo.Marca);
        }
    }
}
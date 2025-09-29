namespace OO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo = new Vehiculo("3176-LBZ","Seat");
            miVehiculo.Marca = "Citroen";
            miVehiculo.Modelo = "C8";
            miVehiculo.Acelerar(5, true);
            Console.WriteLine("Hello, World!");
        }
    }
}
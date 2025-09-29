namespace OO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo = new Vehiculo("7306-GZS");
            miVehiculo.Marca = "Citroen";
            miVehiculo.Modelo = "C8";
            Vehiculo miVehiculo2 = new Vehiculo("3388-JSX");
            miVehiculo.Acelerar(5, true);
            Vehiculo miVehiculo3 = new Vehiculo("3176-LBZ", "Seat");
            Console.WriteLine("Hello, World!");
        }
    }
}
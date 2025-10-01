namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Escribe el primer número: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {calculadora.Sumar(x, y)}");
            Console.WriteLine($"{x} - {y} = {calculadora.Restar(x, y)}");
            Console.WriteLine($"{x} * {y} = {calculadora.Multiplicar(x, y)}");
            if (y != 0)
            {
                Console.WriteLine($"{x} / {y} = {calculadora.Dividir(x, y)}");
            } else
            {
                Console.WriteLine("No se puede realizar la división ya que no se puede dividir un número entre 0.");
            }

        }
    }
}
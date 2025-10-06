using System;

namespace Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                char opcion;

                do
                {
                    Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
                    Console.WriteLine("P - Mostrar números primos (1 al 30)");
                    Console.WriteLine("N - Mostrar números no primos (1 al 30)");
                    Console.WriteLine("S - Salir del programa");
                    Console.Write("Elige una opción: ");

                    opcion = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 'P':
                            Console.WriteLine("\nMostrando números primos:\n");
                            Varios.MostrarPrimos();
                            break;

                        case 'N':
                            Console.WriteLine("\nMostrando números no primos:\n");
                            Varios.MostrarNoPrimos();
                            break;

                        case 'S':
                            Console.WriteLine("\nSaliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Por favor, pulsa P, N o S.");
                            break;
                    }

                } while (opcion != 'S');
            }
        }
    }
}
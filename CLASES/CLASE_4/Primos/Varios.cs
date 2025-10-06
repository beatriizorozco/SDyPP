using System;

namespace Primos
{
    internal class Varios
    {
        public static void MostrarPrimos()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine($"El número {i} es primo.");
                }
            }
        }
        public static void MostrarNoPrimos()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (!EsPrimo(i))
                {
                    Console.WriteLine($"El número {i} no es primo.");
                }
            }
        }

        private static bool EsPrimo(int numero)
        { 
           if (numero < 2)
            {
                return false;
            }
           else if (numero >= 2)
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                        return false;
                }
            }
            return true;
        } 
    }
}

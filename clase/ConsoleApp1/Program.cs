using System;
using ClassLibrary1;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Recoger un valor de la línea de comando
            Datetime momentoActual = DateTime.Now;
            string line = Console.ReadLine();
            int elNumero = Convert.ToInt32(line);
            ClassLibrary1.Persona laPersona = new ClassLibrary1.Persona("Marta");
            Console.WriteLine(line.ToUpper(System.Globalization.CultureInfo.CurrentCulture));
        }
    }
}
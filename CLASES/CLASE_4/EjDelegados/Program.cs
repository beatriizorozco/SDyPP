using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase = new OtraClase();
            Deposito deposito = new Deposito();
            deposito.DelegadoEjecutar += Metodo1;
            deposito.DelegadoEjecutar += otraClase.OtroMetodo;
            deposito.EjecutarLosMetodosEnLosDelegados("Texto Prueba");

            deposito.DelegadoEjecutar("Otro Texto Prueba");

            deposito.EventoEjecutar += Metodo1;
            deposito.DispararElEvento("TextoEvento");
            
            //El evento (se puede llamar fuera) es un delegado (array de métodos en su interior) que queda encapsulado en el mismo objeto donde está el evento. ???

            Console.WriteLine("Hello, World!");
        }

        public static void Metodo1(string ElTexto)
        {
            Console.WriteLine($"Metodo 1: {ElTexto}");
        }
    }
}
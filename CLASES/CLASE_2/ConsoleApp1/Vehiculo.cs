using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
	internal class Vehiculo
	{
		private static int numVehiculosCreados = 0;
		private string marca = "Ford";

		public readonly string Matricula;

		private int velocidad = 0;

        internal Vehiculo(string laMatricula):
			this(laMatricula, string.Empty)
        {
        }

        internal Vehiculo(string laMatricula, string laMarca)
		{
			this.Matricula = laMatricula;
			this.Marca = laMarca;
			Vehiculo.numVehiculosCreados += 1;
		}

		internal string Marca
		{
			get
			{
				return marca;
			}
			set
			{
				marca = value;
			}
		}

        public string Modelo { get; set; }

		public int Velocidad { get => velocidad;}

        public void Acelerar(int kmPorHora)
        {
			this.Acelerar(kmPorHora, false);
        }

        public void Acelerar(int kmPorHora, bool usarTurbo)
		{
			if (usarTurbo)
			{
				Console.WriteLine("Usando el turbo");
			}
			this.velocidad = this.velocidad + kmPorHora;
		}
    }
}

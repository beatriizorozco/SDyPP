using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
	internal class Vehiculo
	{
		private string marca = "Ford";

		public readonly string Matricula;

		private int velocidad = 0;

		public Vehiculo(string laMatricula, string laMarca)
		{
			this.Matricula = laMatricula;
			this.Marca = laMarca;
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
            this.velocidad = this.velocidad + kmPorHora;
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

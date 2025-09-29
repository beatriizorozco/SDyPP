using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1
{
	internal class Vehiculo
	{
		internal string marca = "Ford";

		public Vehiculo()
		{

		}

		internal Vehiculo(string marca)
		{
			this.Marca = marca;
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
	}
}

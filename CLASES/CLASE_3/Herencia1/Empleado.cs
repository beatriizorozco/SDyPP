using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Herencia1
{
    internal class Empleado : Persona
    {
        public Empleado(string ElNombre)
        {
        }
        public int IdEmpleado { get; set; }
        public Empleado(string ElNombre, int ElIdEmpleado): base(ElNombre)
        {
            this.IdEmpleado = ElIdEmpleado;
        }

        public override void ComunicarIncidencia(string ExplicacionIncidencia)
        {
            base.ComunicarIncidencia(ExplicacionIncidencia);
            Console.WriteLine($"Comunicar incidencia desde Empleado: {this.Nombre}. Avisar RRHH");
        }
    }
}

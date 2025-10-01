using System;

namespace Herencia1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }

        public Persona()
        {

        }

        public Persona(String elNombre)
        { 
            this.Nombre = elNombre;
        }
        public virtual void ComunicarIncidencia(string ExplicacionIncidencia) //Virtual -> Clases derivadas van a poder sobreescribirle
        {
            //base.ComunicarIncidencia(ExplicacionIncidencia);
            Console.WriteLine($"Comunicar incidencia desde Persona: {this.Nombre}. Explicación: {ExplicacionIncidencia}");
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}

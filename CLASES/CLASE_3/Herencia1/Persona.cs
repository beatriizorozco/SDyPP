using System;

namespace Herencia1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }

        public Persona(String elNombre)
        { 
            this.Nombre = elNombre;
        }
        public void ComunicarIncidencia(string ExplicacionIncidencia)
        {
            Console.WriteLine($"Comunicar incidencia desde Persona: {this.Nombre}. Explicación: {ExplicacionIncidencia}");
        }
    }
}

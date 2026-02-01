using System; // Importar espacio de nombres

namespace ParqueDiversiones // Definir el espacio de nombres ParqueDiversiones
{
    class Persona // Definir la clase Persona
    {
        public string Nombre { get; set; } // Propiedad para el nombre de la persona
        public int Asiento { get; set; } // Propiedad para el número de asiento de la persona

        public Persona(string nombre, int asiento) // Constructor de la clase Persona
        {
            Nombre = nombre; // Asignar el nombre
            Asiento = asiento;
        }
    }
}

using System; // Importar espacio de nombres
using System.Collections.Generic; // Importar espacio de nombres para usar Queue

namespace ParqueDiversiones // Definir el espacio de nombres ParqueDiversiones
{
    class Atraccion // Definir la clase Atraccion
    {
        private Queue<Persona> cola = new Queue<Persona>(); // Cola para gestionar las personas
        private int capacidad = 30; // Capacidad máxima de la atracción
        private int contadorAsientos = 1; // Contador para asignar números de asiento

        public void RegistrarPersona(string nombre) // Método para registrar una persona
        {
            if (cola.Count < capacidad) // Verificar si hay asientos disponibles
            {
                Persona p = new Persona(nombre, contadorAsientos); // Crear nueva persona con nombre y asiento
                cola.Enqueue(p); // Agregar persona a la cola

                Console.WriteLine($"Persona registrada: {nombre} - Asiento {contadorAsientos}"); // Confirmar registro
                contadorAsientos++; // Incrementar contador de asientos
            }
            else // Si no hay asientos disponibles
            {
                Console.WriteLine("Todos los asientos han sido vendidos."); // Informar al usuario
            }
        }

        public void MostrarCola() // Método para mostrar la cola de personas
        {
            if (cola.Count == 0) // Verificar si la cola está vacía
            {
                Console.WriteLine("No hay personas registradas."); // Informar al usuario
                return; // Salir del método
            }

            Console.WriteLine("\n--- Lista de Personas ---"); // Encabezado de la lista

            foreach (var persona in cola) // Recorrer cada persona en la cola
            {
                Console.WriteLine($"Nombre: {persona.Nombre} | Asiento: {persona.Asiento}"); // Mostrar nombre y asiento de la persona
            }
        }

        public void ConsultarEstado() // Método para consultar el estado de la atracción
        {
            Console.WriteLine("\n--- Estado de la Atracción ---"); // Encabezado del estado
            Console.WriteLine($"Asientos ocupados: {cola.Count}"); // Mostrar asientos ocupados
            Console.WriteLine($"Asientos disponibles: {capacidad - cola.Count}"); // Mostrar asientos disponibles
        }
    }
}

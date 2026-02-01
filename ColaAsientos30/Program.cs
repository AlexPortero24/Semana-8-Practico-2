using System;// Path: ColaAsientos30/Atraccion.cs

namespace ParqueDiversiones// Path: ColaAsientos30/Program.cs
{
    class Program// Path: ColaAsientos30/Program.cs
    {
        static void Main(string[] args)// Path: ColaAsientos30/Program.cs
        {
            Atraccion atraccion = new Atraccion();// Path: ColaAsientos30/Program.cs
            int opcion;// Path: ColaAsientos30/Program.cs

            do// Path: ColaAsientos30/Program.cs
            {
                Console.WriteLine("\n===== PARQUE DE DIVERSIONES ====="); // Mostrar menú
                Console.WriteLine("1. Registrar Persona"); // Opción para registrar persona
                Console.WriteLine("2. Mostrar Cola"); // Opción para mostrar cola
                Console.WriteLine("3. Consultar Estado"); // Opción para consultar estado
                Console.WriteLine("4. Salir"); // Opción para salir
                Console.Write("Seleccione una opción: ");// Solicitar opción al usuario

                opcion = int.Parse(Console.ReadLine());// Leer opción ingresada

                switch (opcion) // Manejar opciones del menú
                {
                    case 1: // Registrar persona
                        Console.Write("Ingrese nombre: "); // Solicitar nombre de la persona
                        string nombre = Console.ReadLine(); // Leer nombre ingresado
                        atraccion.RegistrarPersona(nombre); // Registrar persona en la atracción
                        break; // Fin case 1

                    case 2: // Mostrar cola
                        atraccion.MostrarCola(); // Mostrar la cola de personas
                        break;// Fin case 2

                    case 3: // Consultar estado
                        atraccion.ConsultarEstado(); // Consultar el estado de la atracción
                        break; // Fin case 3
                }

            } while (opcion != 4); // Continuar hasta que el usuario elija salir
        }
    }
}

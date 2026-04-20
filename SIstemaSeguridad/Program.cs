using SistemaSeguridad.Seguridad;
using SIstemaSeguridad.SistemaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIstemaSeguridad
{

class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool ejecutar = true;

            while (ejecutar)
            {
                Console.Clear();
                Console.WriteLine("    SISTEMA DE SEGURIDAD - FACTORY METHOD    ");
                Console.WriteLine("");
                Console.WriteLine("1. Instanciar Alarma");
                Console.WriteLine("2. Instanciar Cámara");
                Console.WriteLine("3. Instanciar Sensor de Movimiento");
                Console.WriteLine("4. Salir del programa");
                Console.WriteLine();
                Console.Write("Seleccione una opción (1-4): ");

                string seleccion = Console.ReadLine();

                if (seleccion == "4")
                {
                    ejecutar = false;
                    Console.WriteLine("\nCerrando sistema... ¡Hasta luego!");

                    continue;
                }

                string tipoParaFabrica = "";

                switch (seleccion)
                {
                    case "1": tipoParaFabrica = "alarma"; break;
                    case "2": tipoParaFabrica = "camara"; break;
                    case "3": tipoParaFabrica = "sensor"; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[ERROR] Opción no válida. Intente de nuevo.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();
                        continue;
                }

                try
                {
                    ISistemaSeguridad dispositivo = SeguridadFactory.CrearDispositivo(tipoParaFabrica);

                    Console.WriteLine("\n- ACCIÓN DEL DISPOSITIVO CREADO -");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    dispositivo.Activar();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nHubo un problema: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para realizar otra operación...");
                Console.ReadKey();
            }
        }
    }
}

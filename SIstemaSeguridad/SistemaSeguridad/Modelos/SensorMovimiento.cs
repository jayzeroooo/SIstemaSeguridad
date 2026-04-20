using SIstemaSeguridad.SistemaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSeguridad.Seguridad
{
    public class SensorMovimiento : ISistemaSeguridad
    {
        public void Activar()
        {
            Console.WriteLine("[DISPOSITIVO] Sensor: Vigilancia infrarroja activa. Escaneando área.");
            Console.WriteLine();
        }
    }
}
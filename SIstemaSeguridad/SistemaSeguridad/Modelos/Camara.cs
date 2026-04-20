using SIstemaSeguridad.SistemaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSeguridad.Seguridad
{
    public class Camara : ISistemaSeguridad
    {
        public void Activar()
        {
            Console.WriteLine("[DISPOSITIVO] Cámara: Lente activo. Grabando y transmitiendo video.");
            Console.WriteLine();
        }
    }
}

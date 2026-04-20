using SIstemaSeguridad.SistemaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSeguridad.Seguridad
{
    public class Alarma : ISistemaSeguridad
    {
        public void Activar()
        {
            Console.WriteLine("[DISPOSITIVO] Alarma: Sirena activada. Sonido de 120dB iniciado.");
            Console.WriteLine();
        }
    }
}

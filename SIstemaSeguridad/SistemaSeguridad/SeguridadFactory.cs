using SIstemaSeguridad.SistemaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSeguridad.Seguridad
{
    public static class SeguridadFactory
    {
        public static ISistemaSeguridad CrearDispositivo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "alarma":
                    return new Alarma();
                case "camara":
                    return new Camara();
                case "sensor":
                    return new SensorMovimiento();
                default:
                    throw new ArgumentException("El tipo de dispositivo no existe.");
            }
        }
    }
}
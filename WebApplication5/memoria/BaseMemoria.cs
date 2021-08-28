using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.memoria
{
    public class BaseMemoria
    {
        // esa propiedad es la misma para todos los usuarios.
        // singleton
        public static List<Cuenta> Cuentas=new List<Cuenta>();
        public static List<CuentaMovimiento> CuentaMovimientos = new List<CuentaMovimiento>();
        public static List<CuentaTemporal> CuentaMCuentaTemporales = new List<CuentaTemporal>();

        // BaseMemoria.Historicos

        public static List<Historico> Historicos = new List<Historico>(); // heap
        public static List<CuentaPlanilla> Plantillas = new List<CuentaPlanilla>(); // heap
    }
}

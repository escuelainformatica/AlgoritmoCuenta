using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public enum TipoMovimientoEnum {
        Deposito=1,Retiro=2
    }

    public class CuentaMovimiento
    {
        public string Rut { set; get;}
        /// <summary>
        /// 0=ingreso, 1=egreso
        /// </summary>
        public int TipoMovimiento { set; get;}
        public int Monto { set; get;}
    }
}

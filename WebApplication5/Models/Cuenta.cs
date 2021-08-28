using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public enum CuentaEstado
    {
        Inactiva=0,
        Activa=1
    }
    public class Cuenta : ICuenta
    {
        public string Rut { set; get; }
        public string Nombre { set; get; }
        public int Estado { set; get; }
        /// <summary>
        /// monto que esta depositado, linea de sobregiro.
        /// </summary>
        public int Saldo { set; get; }
    }
}

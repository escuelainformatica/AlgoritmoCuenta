using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class CuentaTemporal : ICuenta
    {
        public string Rut { set; get; }
        public string Nombre { set; get; }
        public int Estado { set; get; }
        public int Saldo { set; get; }
    }
}

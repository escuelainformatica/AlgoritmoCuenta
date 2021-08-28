using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public enum HistoricoEnum
    {
        ACTIVO=1,
        CERRADA=2,
        SANCIONADA=3,
        NO_EXISTE=4
    }

    public class Historico
    {
        public string Rut { set; get;}
        public int Estado { set; get;}
    }
}

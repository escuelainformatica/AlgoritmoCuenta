using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WebApplication5.memoria;
using WebApplication5.Models;

namespace WebApplication5.servicio
{
    public class HistoricoServicio
    {
        public static bool Insertar(ICuenta cuenta, HistoricoEnum estado) {
            Historico hist=new Historico
            {
                Rut=cuenta.Rut,
                Estado=(int)estado
            };
            BaseMemoria.Historicos.Add(hist);
            return true;
        }
        public static HistoricoEnum EstadoCuenta(ICuenta cuenta)
        {
            if(cuenta.Estado==(int)CuentaEstado.Inactiva)
            {
                return HistoricoEnum.CERRADA;
            }
            var historicoCuenta=BaseMemoria.Historicos
                .Where( h => h.Rut==cuenta.Rut)
                .FirstOrDefault();
            if(historicoCuenta==null)
            {
                return HistoricoEnum.NO_EXISTE;
            }
            return (HistoricoEnum)historicoCuenta.Estado;
        }
    }
}

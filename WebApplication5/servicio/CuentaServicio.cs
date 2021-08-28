using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.memoria;
using WebApplication5.Models;

namespace WebApplication5.servicio
{
    public class CuentaServicio
    {
        public static bool CreacionCuenta(string rut,string nombre,int depositoInicial) 
        {
            CuentaTemporal cuentaTemporal=new CuentaTemporal
            {
                Rut=rut,
                Nombre=nombre,
                Estado=(int)CuentaEstado.Activa
            };
            BaseMemoria.CuentaMCuentaTemporales.Add(cuentaTemporal);

            var condicion=CuentaPlantillaServicio.RevisarUltimas6(cuentaTemporal);
            if(condicion==false)
            {
                return false;
            }
            var revisarhistorico=HistoricoServicio.EstadoCuenta(cuentaTemporal);
            if(revisarhistorico!=HistoricoEnum.NO_EXISTE)
            {
                return false;
            }
            var mov=CuentaMovimientoServicio.Deposito(cuentaTemporal, depositoInicial);
            if(mov==false)
            {
                return false;
            }
            Cuenta cuentaFinal=new Cuenta
            {
                Rut=cuentaTemporal.Rut,
                Nombre=cuentaTemporal.Nombre,
                Estado=(int)CuentaEstado.Activa,
                Saldo= depositoInicial // el deposito inicial
            };
            BaseMemoria.Cuentas.Add(cuentaFinal);

            cuentaTemporal.Estado=(int)CuentaEstado.Inactiva;

            HistoricoServicio.Insertar(cuentaFinal,HistoricoEnum.ACTIVO);

            return true;
        }
    }
}

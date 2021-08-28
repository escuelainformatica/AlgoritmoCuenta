using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.memoria;
using WebApplication5.Models;

namespace WebApplication5.servicio
{
    public static class CuentaMovimientoServicio
    {
        public static bool Deposito(ICuenta cuenta,int monto)
        {
            if (cuenta.Estado == (int)CuentaEstado.Inactiva)
            {
                return false;
            }
            if (monto <= 0)
            {
                return false;
            }
            CuentaMovimiento mov=new CuentaMovimiento { 
                Rut=cuenta.Rut
                ,Monto=monto
                ,TipoMovimiento=(int)TipoMovimientoEnum.Deposito
                };
            BaseMemoria.CuentaMovimientos.Add(mov);
            return true;
        } // colector de basura (garbage collector)

        public static bool Retiro(ICuenta cuenta, int monto)
        {
            if(cuenta.Estado==(int)CuentaEstado.Inactiva)
            {
                return false;
            }
            if(monto<=0)
            {
                return false;
            }
            if(cuenta.Saldo<monto)
            {
                return false;
            }
            // cuanto es el saldo?
            CuentaMovimiento mov = new CuentaMovimiento { 
                Rut = cuenta.Rut
                , Monto = monto
                , TipoMovimiento = (int)TipoMovimientoEnum.Retiro 
            };
            BaseMemoria.CuentaMovimientos.Add(mov);
            return true;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.memoria;
using WebApplication5.Models;

// cuando utilizar el for
// si no tengo un listado (arreglo)
// cuando tengo una condicion inicial y final.    si voy a contar del 1 al 10.
// cuando no sepa cuando terminar, usar un while.
// cuando necesito la posicion (el indice).

namespace WebApplication5.servicio
{
    public static class CuentaPlantillaServicio
    {
        public static bool RevisarUltimas6(ICuenta cuenta)
        {
            var plantillas=BaseMemoria.Plantillas.Where( p =>p.Rut==cuenta.Rut).ToList();
            if(plantillas.Count<6)
            {
                return false;
            }
            foreach(var plantilla in plantillas)
            {
                if(plantilla.Salario<100)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

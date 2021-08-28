using NUnit.Framework;
using System.Linq;
using WebApplication5.memoria;
using WebApplication5.Models;
using WebApplication5.servicio;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // BaseMemoria.Cuentas
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut="1-2",Salario=200});
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "1-2", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "1-2", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "1-2", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "1-2", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "1-2", Salario = 200 });

            BaseMemoria.Historicos.Add(new Historico {  
                Rut="4-5"
                ,Estado=(int)HistoricoEnum.SANCIONADA}
            );
            BaseMemoria.Historicos.Add(new Historico
            {
                Rut = "5-6"
                ,
                Estado = (int)HistoricoEnum.SANCIONADA
            }
            );

            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "5-6", Salario = 200 });


            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
            BaseMemoria.Plantillas.Add(new CuentaPlanilla { Rut = "6-7", Salario = 200 });
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true,CuentaServicio.CreacionCuenta("1-2","john",100));
            Assert.NotNull(BaseMemoria.Cuentas.Where( c=>c.Rut=="1-2").FirstOrDefault());

            Assert.AreEqual(false, CuentaServicio.CreacionCuenta("2-3", "annah",100));

            Cuenta bob=new Cuenta { Rut="4-5",Nombre="bob",Estado=(int)CuentaEstado.Activa};
            Assert.AreEqual(false, CuentaPlantillaServicio.RevisarUltimas6(bob));

            Assert.AreEqual(false, CuentaServicio.CreacionCuenta("5-6", "susan",100));

            Assert.AreEqual(false, CuentaServicio.CreacionCuenta("6-7", "negativo", -100));

        }
    }
}
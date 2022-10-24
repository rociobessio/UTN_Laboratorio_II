using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unidad_13_Interfaces_Biblioteca_Ejercicio_I02;
using System.Collections.Generic;


namespace Unidad_13_Interfaces_Tests_Ejercicio_I02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange (Instanciar obj)
            PaqueteFragil paqueteFragil = new PaqueteFragil("45632",4532,"Argelia","Brasil",14.23);

            //Act
            bool esFragil = paqueteFragil.TienePrioridad; //Con la propiedad obtengo un valor

            //Assert
            Assert.IsTrue(esFragil);//Veo si me retorna TRUE
        }

        /// <summary>
        /// Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio de la clase PaqueteFragilTest.
        /// Deberá verificar que la propiedad Impuestos,  cuando se invoca de forma implícita desde una instancia de PaqueteFragil,
        /// retorne el 35% del costo de envío.
        /// </summary>
        [TestMethod]
        public void Impuestos_DeberiaRetornarVAlorDelImpuestoDel135PorcientoSobreCostoEnvio()
        {
            //Arrange (Instanciar obj)
            decimal costoEnvio = 100;
            decimal valorEsperado = 35;
            
            PaqueteFragil paqueteFragil = new PaqueteFragil("45632", costoEnvio, "Argelia", "Brasil", 14.23);

            //Act
            decimal valorRetornado = paqueteFragil.Impuestos; //Con la propiedad obtengo un valor

            //Assert
            Assert.AreEqual(valorRetornado,valorEsperado);//Veo si los valores son iguales
        }

        /// <summary>
        /// Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana de la clase PaqueteFragilTest. 
        /// Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaqueteFragil, 
        /// retorne el costo del envío con el impuesto de aduana aplicado.
        /// </summary>
        [TestMethod]
        public void Impuestos_DeberiaRetornarElCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange (Instanciar obj)
            decimal costoEnvio = 100;
            decimal valorEsperado = 135;

            PaqueteFragil paqueteFragil = new PaqueteFragil("45632", costoEnvio, "Argelia", "Brasil", 14.23);

            //Act
            decimal valorRetornado = paqueteFragil.AplicarImpuestos(); //Con la propiedad obtengo un valor

            //Assert
            Assert.AreEqual(valorRetornado, valorEsperado);//Veo si los valores son iguales
        }
    }
}

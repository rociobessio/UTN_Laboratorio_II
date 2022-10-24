using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unidad_13_Interfaces_Biblioteca_Ejercicio_I02;

namespace Unidad_13_Interfaces_Tests_Ejercicio_I02
{
    [TestClass]
    public class PaquetePesadoTest
    {

        /// <summary>
        /// implementar la prueba unitaria TienePrioridad_DeberiaRetornarFalse de la clase PaquetePesadoTest. 
        /// Deberá verificar que la propiedad TienePrioridad retorne false para las instancias de PaquetePesado.
        /// </summary>
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange (Instanciar obj)
            PaquetePesado paquetePesado = new PaquetePesado("45632", 4532, "Argelia", "Brasil", 14.23);

            //Act
            bool esFragil = paquetePesado.TienePrioridad; //Con la propiedad obtengo un valor

            //Assert
            Assert.IsFalse(esFragil);//Veo si me retorna FALSE
        }

        /// <summary>
        /// Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita
        /// de la clase PaquetePesadoTest. Deberá verificar que la propiedad Impuestos, cuando se invoca de forma implícita desde una
        /// instancia de PaquetePesado, retorne el 35% del costo de envío.
        /// </summary>
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorDelImpuestoDel135PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange (Instanciar obj)
            decimal costoEnvio = 100;
            decimal valorEsperado = 35;

            //Arrange (Instanciar obj)
            PaquetePesado paquetePesado = new PaquetePesado("45632", costoEnvio, "Argelia", "Brasil", 14.23);

            //Act
            decimal valorRetornado = paquetePesado.Impuestos; //Con la propiedad obtengo un valor

            //Assert
            Assert.AreEqual(valorRetornado, valorEsperado);//Veo si los valores son iguales
        }


        /// <summary>
        /// Implementar la prueba unitaria Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip de la clase PaquetePesadoTest.
        /// Deberá verificar que la propiedad Impuestos, cuando se invoca de forma explícita desde una referencia de tipo IAfip,
        /// retorne el 25% del costo de envío.
        /// </summary>
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            //Arrange (Instanciar obj)
            decimal costoEnvio = 100;
            decimal valorEsperado = 25;

            PaquetePesado paquetePesado = new PaquetePesado("45632", costoEnvio, "Argelia", "Brasil", 14.23);

            //Act
            decimal valorRetornado = ((IAfip)paquetePesado).Impuestos; //Casteo de forma explicita, ya que la propiedad es explicita.

            //Assert
            Assert.AreEqual(valorRetornado, valorEsperado);//Veo si los valores son iguales
        }

        /// <summary>
        /// Implementar la prueba unitaria AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana de la clase PaquetePesadoTest.
        /// Deberá verificar que el método AplicarImpuestos, cuando se invoca de forma implícita desde una instancia de PaquetePesado,
        /// retorne el costo de envío con ambos impuestos de AFIP y aduana aplicados.
        /// </summary>
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange (Instanciar obj)
            decimal costoEnvio = 100;
            decimal valorEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado("45632", costoEnvio, "Argelia", "Brasil", 1);

            //Act
            decimal valorRetornado = paquetePesado.AplicarImpuestos(); //Innvoco de forma implicita, es decir, no necesito un casteo.

            //Assert
            Assert.AreEqual(valorRetornado, valorEsperado);//Veo si los valores son iguales
        }
    }
}

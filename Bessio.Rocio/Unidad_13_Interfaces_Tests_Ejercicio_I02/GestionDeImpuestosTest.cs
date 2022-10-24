using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unidad_13_Interfaces_Biblioteca_Ejercicio_I02;
using System.Collections.Generic;

namespace Unidad_13_Interfaces_Tests_Ejercicio_I02
{
    [TestClass]
    public class GestionDeImpuestosTest
    {
        /// <summary>
        /// Implementar la prueba unitaria CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana de la clase
        /// GestionImpuestosTest. Deberá verificar que el método CalcularTotalImpuestosAduana retorne la suma de los impuestos de 
        /// aduana. Realizar la prueba con al menos un paquete de cada tipo.
        /// </summary>
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange (Instanciar obj)
            decimal valorEsperado = 105;
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaquetePesado("45632", 4532, "Argelia", "Brasil", 14.23));
            paquetes.Add(new PaqueteFragil("78951", 2638, "Nirvana", "Irak", 320.2));

            GestionDeImpuestos gestionDeImpuestos = new GestionDeImpuestos();
            gestionDeImpuestos.RegistrarImpuestos(paquetes);
            //Act
            decimal valorRetornados = gestionDeImpuestos.CalcularTotalImpuestosAduana(); //Con la propiedad obtengo un valor

            //Assert
            Assert.AreEqual(valorRetornados,valorEsperado);//Veo si me retorna FALSE
        }

        /// <summary>
        /// Implementar la prueba unitaria CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip 
        /// de la clase GestionImpuestosTest. Deberá verificar que el método CalcularTotalImpuestosAfip retorne la suma de los impuestos de 
        /// AFIP. Realizar la prueba con al menos un paquete de cada tipo.
        /// </summary>
        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange (Instanciar obj)
            decimal valorEsperado = 105;
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaquetePesado("45632", 4532, "Argelia", "Brasil", 14.23));
            paquetes.Add(new PaqueteFragil("78951", 2638, "Nirvana", "Irak", 320.2));

            GestionDeImpuestos gestionDeImpuestos = new GestionDeImpuestos();
            gestionDeImpuestos.RegistrarImpuestos(paquetes);
            //Act
            decimal valorRetornados = gestionDeImpuestos.CalcularTotalImpuestosAfip(); //Con la propiedad obtengo un valor

            //Assert
            Assert.AreEqual(valorRetornados, valorEsperado);//Veo si me retorna FALSE
        }

    }
}

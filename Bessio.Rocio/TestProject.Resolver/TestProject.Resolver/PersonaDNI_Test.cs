using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnitarios.ClassLibrary;

namespace TestProject.Resolver
{
    [TestClass]
    public class PersonaDNI_Test
    {
        /// <summary>
        /// Comprobar que el DNI en formato texto NO pueda tener:
        /// Coma
        /// Letras
        /// Arroja DniInvalidoException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Texto()
        {
            //Arrange
            string dniComa = "30.999,999";
            string dniTexto = "30a00123";


            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dniComa, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniComa);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

            //Completar con dniTexto
            try
            {
                Persona personaSegunda = new Persona("Anibal", "Pachano", dniTexto, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniTexto);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser menor a 1
        /// Arroja NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Bajo()
        {
            //Arrange
            int dni = -10;

            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dni, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dni);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser mayor a 99.999.999
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Alto()
        {
            //Arrange
            int dni = 199999999;

            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dni, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dni);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));//Fallo especifico
            }
        }

        /// <summary>
        /// Comprobar los rangos de DNI para Argentinos
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Argentino()
        {
            //Arrange
            int dniPrimero = 1;
            int dniMedio = new Random().Next(1, 89999999);
            int dniUltimo = 89999999;
            string dniString = "89.999.999";

            //Act y Assert

            Persona personaPrimero = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Argentina);
            Assert.AreEqual(personaPrimero.DNI, dniPrimero);//Si la comparacion es FALSE salta y falla

            //Completar con dniMedio, dniUltimo y dniString
            Persona personaSegundo = new Persona("Juan", "Lopez", dniMedio, ENacionalidad.Argentina);
            Assert.AreEqual(personaSegundo.DNI, dniMedio);

            Persona personaTercero = new Persona("Juan", "Lopez", dniUltimo, ENacionalidad.Argentina);
            Assert.AreEqual(personaTercero.DNI, dniUltimo);

            Persona personaCuarta = new Persona("Juan", "Lopez", dniString, ENacionalidad.Argentina);//El string es el mismo que el Ultimo
            Assert.AreEqual(personaCuarta.DNI, dniUltimo);
        }

        /// <summary>
        /// Comprobar los rangos de DNI para Extranjeros
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Extranjeros()
        {
            //Arrange
            int dniPrimero = 89999999;
            int dniMedio = new Random().Next(89999999, 99999999);
            int dniUltimo = 99999999;
            string dniString = "99.999.999";

            //Act y Assert

            Persona personaPrimero = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Extranjera);
            Assert.AreEqual(personaPrimero.DNI, dniPrimero);//Si la comparacion es FALSE salta y falla

            //Completar con dniMedio, dniUltimo y dniString
            Persona personaSegundo = new Persona("Juan", "Lopez", dniMedio, ENacionalidad.Extranjera);
            Assert.AreEqual(personaSegundo.DNI, dniMedio);

            Persona personaTercero = new Persona("Juan", "Lopez", dniUltimo, ENacionalidad.Extranjera);
            Assert.AreEqual(personaTercero.DNI, dniUltimo);

            Persona personaCuarta = new Persona("Juan", "Lopez", dniString, ENacionalidad.Extranjera);//El string es el mismo que el Ultimo
            Assert.AreEqual(personaCuarta.DNI, dniUltimo);
        }
    }
}

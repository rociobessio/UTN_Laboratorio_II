using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiBiblioteca_LaCentralita;
/*
 *      PERTENECE A LA CENTRALITA IV
 * 
 * 
 */
namespace Unidad_11_UnitTest_Ejercicio_C01
{
    [TestClass]
    public class UnitTestCentralita
    {
        /// <summary>
        /// Crear un test unitario que valide que la LISTA de LLAMADAS de la centralita este INSTANCIADA al crear
        /// un nuevo objeto del tipo Centralita
        /// </summary>
        [TestMethod]
        public void TestLlamadasInicializadas()
        {
            //Arrange (Instanciar)
            string nombre = "SantaClaus";

            //Act (Invocar metodos a probar)
            Centralita centralita = new Centralita(nombre);

            //Assert (Evaluar los resultados)
            Assert.IsNotNull(centralita.Llamadas);//Verifico que esten instanciadas las llamadas
        }


        /// <summary>
        /// Controlar mediante un nuevo metodo de test unitario que la excepcion CentralitaException
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos del
        /// origen y destino de una llamada Local ya EXISTENTE.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CentralitaExeption))]//Me fijo que la expected exception sea del tipo CentralitaException
        public void TestCentralitaLocalException()
        {
            //Arrange (Instanciar)
            string nombre = "SantaClaus";
            //Instancio dos llamadas IGUALES
            Local l1 = new Local("4565879",78,"478896",(float)4.32);
            Local l2 = new Local("4565879", 78, "478896", (float)4.32);

            //Act
            Centralita central = new Centralita(nombre);
            central = central + l1;//Intento añadir las llamadas que son iguales
            central = central + l2;//Intento añadir una llamada igual a la lista

            //Assert (Se maneja dentro del ExpectedException !!)
           // Assert.AreEqual(l1,l2);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaExeption))]//Me fijo que la expected exception sea del tipo CentralitaException
        public void TestCentralitaProvincialException()
        {
            //Arrange (Instanciar)
            string nombre = "SantaClaus";
            //Instancio dos llamadas IGUALES
            Provincial p1 = new Provincial("4565879",Provincial.Franja.Franja_1,15,"#5488965");
            Provincial p2 = new Provincial("4565879", Provincial.Franja.Franja_1, 15, "#5488965");

            //Act
            Centralita central = new Centralita(nombre);
            central = central + p1;//Intento añadir las llamadas que son iguales
            central = central + p2;//Intento añadir una llamada igual a la lista

            //Assert (Se maneja dentro del ExpectedException !!)
            // Assert.AreEqual(l1,l2);
        }

        [TestMethod]
        public void TestCentralitaIgualesException()
        {
            //arrange (Instancio objetps)
            string name = "SantaClaus";
            Llamada l1 = new Local("125486",30,"121566",(float)5.36);
            Llamada l2 = new Local("125486", 30, "121566", (float)5.36);
            Provincial p1 = new Provincial("4565879", Provincial.Franja.Franja_1, 15, "#5488965");
            Provincial p2 = new Provincial("4565879", Provincial.Franja.Franja_1, 15, "#5488965");
            
            //act
            Centralita centralita = new Centralita(name);

            //assert (Comparo igualdad de llamdas con el operador == que ya fue sobrecargado)
            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(p1 == p2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 *                    PUESTO DE ATENCION
 *             ------------------------------
 *              UNIDAD 07 - ENCAPSULAMIENTO
 *              
 *  - El atributo numeroActual es estático y privado. Se inicializará en el constructor de clase 
 *    (estático) con valor 0.
    - El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará 
      un tiempo de atención mediante el método Sleep de la clase Thread (perteneciente al espacio de 
      nombre System.Threading) y retornará true para indicar el final de la atención.
    - La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual 
      y luego retornarlo.
 */
namespace MiBiblioteca
{
    public class PuestoAtencion
    {
        #region ATRIBUTOS 
        private static int numeroActual;
        private EPuesto puesto;//Enumerado
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad estatica NumeroActual es la encargada de incrementar en 1 al atributo
        /// numeroActual y luedo retornarlo
        /// </summary>
        public int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// El atributo numeroActual es estatico y privado. Se inicializara em el constructor de clase
        /// estatico con valor 0.
        /// </summary>
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El metodo Atender simulara un tiempo de atencion de un cliente: recibe un cliente, simula 
        /// un tiempo de atencion mediante el metodo Sleep de la clase Thread y retorna true para indicar
        /// el final de la atencion.
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool Atender(Cliente cli)
        {
            bool termino = false;
            if (cli is not null)//Valido que cli no sea null
            {
                //Suspende el Thread por una cantidad especifica de tiempo!
                Thread.Sleep(2000);//simulo tiempo de atencion
                termino = true;
            }
            return termino; 
        }

        #endregion
    }
}

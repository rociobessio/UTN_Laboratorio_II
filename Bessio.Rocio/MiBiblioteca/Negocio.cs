using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    public class Negocio
    {
        #region ATRIBUTOS
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad Cliente retorna el proximo cliente en la cola de atencion en el get.
        /// El set debera constrolar que el Cliente no figure en la cola de atencion, caso contrario 
        /// lo agregara.
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();//Retorna al proximo cliente de la lista
            }
            set
            {//Debera de controlar que el Cliente NO figure en la cola de atencion, si no, lo agrega 
                _ = this + value;
            }
        }
        /// <summary>
        /// La propiedad ClientesPendientes retornara la cantidad de clientes esperando a ser atendidos.
        /// </summary>
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }
        #endregion

        #region METODOS

        #region CONSTRUCTORES
        private Negocio()
        {
            this.caja = new PuestoAtencion(EPuesto.Caja1);//Inicializo la Coleccion
            this.clientes = new Queue<Cliente>();//Inicializo la Queue
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Retorna true si el cliente se encuentra en la coleccion
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator == (Negocio n,Cliente c)
        {
            bool estaONo = false;

            foreach (Cliente objCliente in n.clientes)
            {
                if(objCliente == c)
                {
                    estaONo = true;
                }
            }
            return estaONo;
        }

        public static bool operator != (Negocio n,Cliente c)
        {
            return !(n==c);
        }

        /// <summary>
        /// El operador + sera el unico capaz de agregar un Cliente en la cola de atencion. Solo se 
        /// agregara un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Negocio n,Cliente c)
        {
            bool estaONo = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                estaONo = true;
            }
            return estaONo;
        }

        /// <summary>
        /// El operador ~ generara una atencion del proximo cliente en la cola, utilizando la propiedad
        /// Cliente y el metodo Atender de PuestoAtencion. Retornara true si pudo realizar la operacion. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool operator ~(Negocio n)
        {
            bool pudoONo = false;
            if (n.clientes.Count > 0)
            {//Mediante n accedo a caja(Clase PuestoAtencion), luego al metodo Atender,a la propiedad Cliente
                pudoONo = n.caja.Atender(n.Cliente);
            }
            return pudoONo;
        }
        #endregion

        #endregion


    }
}

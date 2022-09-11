using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *                      CREO QUE NECESITO UN PRESTAMO
 *                   -----------------------------------
 *                      UNIDAD 03 - CLASES - EJER. I01
 * 
 */

namespace MiBiblioteca
{
    public class Cuenta
    {
        #region ATRIBUTOS

        public string titular;
        public float cantidad;
        #endregion

        #region METODOS
        #region CONSTRUCTOR
        /// <summary>
        /// UN CONSTRUCTOR QUE PERMITA INICIALIZAR TODOS LOS ATRIBUTOS
        /// </summary>
        /// <param name="titular"></param>
        /// <param name="cantidad"></param>
        public Cuenta(string titular,float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        #endregion

        #region GETTERS
        /// <summary>
        /// GETTER PARA OBTENER AL TITULAR
        /// </summary>
        /// <returns></returns>
        public string GetTitular()
        {
            return this.titular;
        }

        /// <summary>
        /// GETTER PARA OBTENER LA CANTIDAD
        /// </summary>
        /// <returns></returns>
        public float GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        /// <summary>
        /// RETORNARA UNA CADENA DE TEXTO CON TODOS LOS DATOS DE LA CUENTA 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            float cantidad = this.GetCantidad();
            string titular = this.GetTitular();

            sb.AppendLine($"RAZON DEL TITULAR: {titular}\n");
            sb.AppendLine($"CANTIDAD ACTUAL DE DINERO EN LA CUENTA: {cantidad}");

            return sb.ToString();
        }

        /// <summary>
        /// RECIBE UN MONTO PARA ACREDITAR EN LA CUENTA, SI ES NEGATIVO NO SE HACE NADA
        /// </summary>
        /// <param name="acreditar"></param>
        public void Ingresar(float acreditar)
        {
            if(acreditar>0)
            {
                this.cantidad += acreditar;
            }
        }

        /// <summary>
        /// RECIBIRA UN MONTO PARA DEBITAR DE LA CUENTA. LA CUENTA PUDE QUEDAR EN NEGATIVO!
        /// </summary>
        /// <param name="debitar"></param>
        public void Retirar(float debitar)
        {
            this.cantidad -= debitar;
        }
        #endregion
    }
}

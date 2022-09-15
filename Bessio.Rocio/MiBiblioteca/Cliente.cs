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
 *  La sobrecarga del operador == retornará true si dos clientes tienen el mismo número.
 */
namespace MiBiblioteca
{
    public class Cliente
    {

        #region ATRIBUTOS   
        private string nombre;
        private int numero;
        #endregion

        #region METODOS DE LA CLASE

        #region PROPIEDADES
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        #region CONSTRUCTORES
        public Cliente()
        {
            this.nombre = "";
            this.numero = 0;
        }

        public Cliente(int numero, string nombre)
        {
            this.nombre = nombre;
            this.numero = numero;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador == retorna true si dos clientes tienen el mismo numero
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator == (Cliente c1, Cliente c2)
        {
            bool esNull = false;
            if (c1 is not null && c2 is not null)
            {
                esNull = c1.numero == c2.numero;//Retorna true si los dos CLientes tinene el mismo numero
            }
            else if (c1 is null && c2 is null)
            {
                esNull = true;
            }
            return esNull;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion


        #endregion



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_09_ClaseRepaso_PP
{
    public abstract class Mascota
    {
        #region ATRIBUTOS
        private string nombre;
        private string raza;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } }
        public string Raza { get { return this.raza; } }
        #endregion

        #region CONSTRUCTOR
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Método virtual y protegido DatosCompletos() . Retornará el nombre y 
        /// el raza con el formato "Nombre - Raza".
        /// Por fuera de la herencia este metodo es INACCESIBLE
        /// </summary>
        /// <returns></returns>
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} - {this.raza}");

            return sb.ToString();
        }

        /// <summary>
        /// Método abstracto y protegido Ficha() .
        /// </summary>
        /// <returns></returns>
        protected abstract string Ficha();

        #endregion


        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Sobrecarga del operador == (igualdad), dos mascotas serán iguales si comparten nombre 
        /// y raza
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (Mascota m1, Mascota m2)
        {
            bool esIgual = false;
            if (m1 is not null && m2 is not null)
            {
                esIgual = (m1.raza == m2.raza && m1.nombre == m2.nombre);
            }
            return esIgual;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion

    }
}

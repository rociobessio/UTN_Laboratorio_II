using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_Ejercicio_Vis
{
    public class Auto
    {
        #region ATRIBUTOS
        private string color;
        private string marca;
        #endregion

        #region PROPIEDADES
        public string Color { get { return this.color; } }
        public string Marca { get { return this.marca; } }
        #endregion

        #region METODOS

        #region CONSTRUCTOR
        public Auto(string color,string marca)
        {
            this.color = color;
            this.marca = marca;
        }
        #endregion

        private string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Color: {this.color} - Marca: {this.marca}");
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        ///  Retorna true, si las marcas y colores de ambos autos son iguales, false, caso contrario.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Auto a1,Auto a2)
        {
            bool esIgual = false;
            if (a1 is not null && a2 is not null)
            {
                esIgual = a1.color == a2.color && a1.marca == a2.marca;
            }
            return esIgual;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// o ToString. Retorna una cadena conteniendo la información del auto (marca y color)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarAuto();
        }

        /// <summary>
        /// Equals. Retorna true, si el objeto a comparar es del tipo auto y tienen la misma marca y color
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Auto)
            {
                esNull = this == ((Auto)obj);
            }
            return esNull;
        }
        #endregion
        #endregion

    }
}

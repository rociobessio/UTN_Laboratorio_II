using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_09_ClaseRepaso_PP;

namespace MIBiblioteca_Unidad_09_ClaseRepaso_PP
{
    public class Gato : Mascota
    {

        #region CONSTRUCTOR
        public Gato(string nombre, string raza) : base(nombre,raza){ }
        #endregion

        #region METODOS

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Dos Gatos serán iguales si comparten nombre y raza. Reutilizar código.
        /// </summary>
        /// <param name="g1"></param>
        /// <param name="g2"></param>
        /// <returns></returns>
        public static bool operator == (Gato g1,Gato g2)
        {
            bool esIgual = false;
            if (g1 is not null && g2 is not null)
            {
                esIgual = ((Mascota)g1 == (Mascota)g2);
            }
            return esIgual;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        #endregion

        #region POLIMORFISMO

        /// <summary>
        /// Implementar el método Ficha(). Retornará toda la información del Gato con un formato 
        /// similar al de Perro
        /// </summary>
        /// <returns></returns>
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Gato)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Gato)obj);
            }
            return esNull;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *                                          ENTIDAD DE LA UNIDAD 06
 *                                       -----------------------------
 *                                            EJERCICIO DE SLACK 
 *                                                  PARTE 01
 */


namespace MiBiblioteca
{
    public class Tempera
    {
        #region ATRIBUTOS
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;
        #endregion

        #region CONSTRUCTOR de 3 PARAMETROS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="marca"></param>
        /// <param name="cantidad"></param>
        public Tempera(ConsoleColor color,string marca,Int32 cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        #region BOOLEANOS
        public static bool operator == (Tempera t1,Tempera t2)
        {
            if ((object)t1 == null)
            {
                return (object)t1 == null;
            }
            if ((object)t2 == null)
            {
                return (object)t2 == null;
            }
            else return t1.marca == t2.marca && t1.color == t2.color;
        }

        public static bool operator !=(Tempera t1,Tempera t2)
        {
            return !(t1 == t2);
        }
        #endregion

        #region OPERADOR +
        /// <summary>
        /// Si temperas iguales, acumula cantidad
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static Tempera operator +(Tempera t1,Tempera t2)
        {
            if(t1 == t2)
            {
                //t1.cantidad++;
                t1.cantidad += t2.cantidad;
            }
            return t1;
        }

        /// <summary>
        /// directamente acumula la cant de segundo paramaetro en el atributo de cantidad del objeto
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="cant"></param>
        /// <returns></returns>
        public static Tempera operator +(Tempera t1, int cant)
        {
            t1.cantidad += cant;
            return t1;
        }

        #endregion

        //OPERADOR EXPLICITO E IMPLICITO
        /// <summary>
        /// retorna la cantidad
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator int(Tempera t)
        {
            return (int)t;
        }
        #endregion

        #region METODO DE LA CLASE
        /// <summary>
        /// De INSTANCIA
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Color Tempera: {this.color}\nCantidad Tempera: {this.cantidad}\nMarca Tempera: {this.marca}");

            return sb.ToString();
        }
    
        /// <summary>
        /// De CLASE
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_Tintas_Vis_Explicacion_02
{
    public class Pluma
    {
        #region ATRIBUTOS
        private string marca;
        private Tinta tinta;
        private int cantidad;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO (0) PARAMETROS
        /// </summary>
        public Pluma()
        {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        /// <summary>
        /// CONSTRUCTOR QUE RECIBE 1 PARAMETRO
        /// </summary>
        /// <param name="marca"></param>
        public Pluma(string marca)
        {
            this.marca = marca;
        }
        /// <summary>
        /// CONSTRUCTOR QUE RECIBE DOS PARAMETROS
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="marca"></param>
        public Pluma(Tinta tinta, string marca) : this(marca)
        {
            this.tinta = tinta;
        }
        /// <summary>
        /// CONSTRUCTOR QUE RECIBE 3 PARAMETROS
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="tinta"></param>
        /// <param name="marca"></param>
        public Pluma(int cantidad,Tinta tinta,string marca) : this(tinta, marca)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region INSTANCIA
        /// <summary>
        /// SIRVE PARA MOSTRAR LOS ATRIBUTOS DE LA CLASE PLUMA
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TINTA DE LA PLUMA: {(string)tinta}");
            sb.AppendLine($"CANTIDAD DE TINTA DE LA PLUMA: {this.cantidad}");
            sb.AppendLine($"MARCA DE LA PLUMA: {this.marca}");

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        #region BOOLEANAS (== , !=)
        /// <summary>
        /// PARA COMPARAR LAS TINTAS
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool operator ==(Pluma p,Tinta t)
        {
            return p.tinta == t;
        }
        /// <summary>
        /// PARA VER SI LAS TINTAS SON DISTINTAS
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p.tinta == t);
        }
        #endregion

        #region  SOBRECARGA DE INCREMENTAR O DECREMENTAR CANTIDADES
        /// <summary>
        /// +(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (incrementar cantidad)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Pluma operator + (Pluma p,Tinta t)
        {
            if(p == t)
            {
                p.cantidad++;
            }
            return p;
        }

        /// <summary>
        /// -(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (decrementar cantidad)
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p == t)
            {
                p.cantidad--;
            }
            return p;
        }
        #endregion

        #region SOBRECARGA IMPLICITA
        /// <summary>
        /// implicit (Pluma):string //se relaciona con mostrar
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();//casteo para mostrar
        }
        #endregion

        #endregion//SOBRECARGAS GENERAL
    }
}

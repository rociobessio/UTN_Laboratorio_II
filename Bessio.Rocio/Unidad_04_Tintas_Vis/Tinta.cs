using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_Tintas_Vis_Explicacion_02
{
    public class Tinta
    {
        #region ATRIBUTOS
        private ConsoleColor color;
        private eTipoTinta tipo;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO CON 0 PARAMETROS
        /// </summary>
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = eTipoTinta.Comun;
        }

        /// <summary>
        /// CONSTRUCTOR CON 1 PARAMETRO
        /// </summary>
        /// <param name="color"></param>
        public Tinta(ConsoleColor color)
        {
            this.color = color;
        }

        /// <summary>
        /// CONSTRUCTOR CON 2 PARAMETROS
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="color"></param>
        public Tinta(eTipoTinta tipo, ConsoleColor color) : this (color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region INSTANCIAS
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"COLOR DE TINTA: {this.color}");
            sb.AppendLine($"TIPO DE TINTA: {this.tipo}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();//REUTILIZO EL MOSTRAR QUE ESTA EN PRIVADO
        }
        #endregion

        #region SOBRECARGAS 
        #region DE OPERADORES BOOLEANOS

        public static bool operator ==(Tinta t1,Tinta t2)
        {
            return t1.color == t2.color && t1.tipo == t2.tipo;
        }

        public static bool operator !=(Tinta t1,Tinta t2)
        {
            return !(t1 == t2);
        }
        #endregion

        #region EXPLICITA
        public static explicit operator string (Tinta t1)
        {
            return t1.Mostrar();
        }
        #endregion

        #endregion


    }
}

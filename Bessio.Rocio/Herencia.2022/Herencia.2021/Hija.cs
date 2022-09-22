using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2022
{
    public class Hija : Padre
    {
        #region Atributo
        public string cadena;

        #endregion

        #region Constructores
        public Hija(int e, string c, double d) : base(e)
        {
            this.cadena = c;
            base.Doble = d;
        }

        public Hija(string c, int e, double d): this(e,c,d)
        {
            base.booleano = true;
        }
        #endregion

        #region Métodos
        public string MostrarHija()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Doble:" + base.Doble);
            sb.AppendLine("Cadena derivada:"+this.cadena);
          
            return sb.ToString();

        }
        #endregion


    }
}

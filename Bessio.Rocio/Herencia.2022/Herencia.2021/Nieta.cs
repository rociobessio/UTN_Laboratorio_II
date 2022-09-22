using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2022
{
    public class Nieta: Hija
    {
        #region Atributo
        private Padre padre;
        #endregion

        #region Constructor
        public Nieta(int e, string c, double d, Padre p) : base(e, c, d)
        {
            this.padre = p;
            base.booleano = true;
        }
        #endregion

        #region Método
        public string MostrarNieta()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarHija());
            sb.AppendLine("Objeto padre derivado:" + this.padre);

            return sb.ToString();

        }
        #endregion

    }
}

using System;
using System.Text;

namespace Entidades
{
    public class ClaseSimple<T> 
    {
        #region Atributo
        private T miAtributo;
        #endregion

        #region Constructores
        public ClaseSimple()
        {
            this.miAtributo =default(T);
        }

        public ClaseSimple(T parametro):this()
        {
            this.miAtributo = parametro;
        }

        #endregion

        #region Método
        public override string ToString()
        {
            try
            {
                return this.miAtributo.ToString();
            }
            catch (NullReferenceException)
            {
                return "Esto fue nulo";
            }
        }

        #endregion

    }
}

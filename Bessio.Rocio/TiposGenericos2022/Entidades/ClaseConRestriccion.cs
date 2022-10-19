using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseConRestriccion<T,U,X>
        where T : X
        where U : unmanaged
        where X : Clase, new()
    {
        #region Atributo
        private T miAtributo;
        private U miAtributo2;
        private X miAtributo3;
        #endregion

        #region Constructores

        public ClaseConRestriccion()
        {
            this.miAtributo = default(T);
            this.miAtributo2 = default(U);
            this.miAtributo3 = default(X);
        }
        public ClaseConRestriccion(T param,U param2,X param3) : this()
        {
            this.miAtributo = param;
            this.miAtributo2 = param2;
            this.miAtributo3 = param3;
        }

        #endregion

        #region Método

        public void Mostrar()
        {
            Console.WriteLine(this.miAtributo.ToString());
            Console.WriteLine(this.miAtributo2.ToString());
            Console.WriteLine(this.miAtributo3.ToString());
        }

        #endregion
    }
}

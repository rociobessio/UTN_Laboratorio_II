using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseMenosSimple<T, U>
    {
        #region Atributos
        private T miAtributo;
        private U miAtributo2; 
        #endregion

        #region Constructor

        public ClaseMenosSimple()
        {
            this.miAtributo = default(T);
            this.miAtributo2 = default(U);
        }
    

        #endregion

        #region Propiedades
        public T MiAtributo
        {
            get 
            { return this.miAtributo; }
            
            set
            {
                this.miAtributo = value;
            }
        }

        public U MiAtributo2
        {
            get
            { return this.miAtributo2; }

            set
            {
                this.miAtributo2 = value;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_16_SQL_Biblioteca_Ejercicio_I03
{
    public class Usuario
    {
        #region ATRIBUTOS
        private int codigoUsuario;
        private string username;
        #endregion

        #region PROPIEDADES
        public int CodigoUsuario { get { return this.codigoUsuario; } set { this.codigoUsuario = value; } }

        #endregion

        #region METODOS

        #region CONSTRUCTOR
        public Usuario(string username,int codigoUsuario)
        {
            this.username = username;
            this.codigoUsuario = codigoUsuario;
        }
        #endregion

        #region POLIMORFISMO
        public override string ToString()
        {
            return $"CODIGO USUARIO: {this.codigoUsuario}\n" +
                   $"USERNAME: { this.username}\n";
        }
        #endregion

        #endregion

    }
}

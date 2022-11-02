using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_16_SQL_Biblioteca_Ejercicio_I03
{
    public class Biblioteca
    {
        #region ATRIBUTOS
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;
        #endregion

        #region PROPIEDADES
        public int CodigoJuego { get { return this.codigoJuego; } }
        public string Genero { get { return this.genero; } }
        public string Juego { get { return this.juego; } }
        public string Usuario { get { return this.usuario; } }
        #endregion

        #region CONSTRUCTOR
        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }

        #endregion
    }
}

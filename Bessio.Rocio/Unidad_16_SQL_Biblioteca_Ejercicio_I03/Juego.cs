using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Unidad_16_SQL_Biblioteca_Ejercicio_I03
{
    public class Juego
    {
        #region ATRIBUTOS
        private int codigoJuego;
        private int codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;
        #endregion

        #region PROPIEDADES
        public int CodigoJuego { get { return this.codigoJuego; } }
        public int CodigoUsuario { get { return this.codigoUsuario; } }
        public string Genero { get { return this.genero; } }
        public string Nombre { get { return this.nombre; } }
        public double Precio { get { return this.precio; } }
        #endregion

        #region CONSTRUCTORES
        public Juego(string nombre, double precio, string genero,int codigoJuego, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoJuego = codigoJuego;
            this.codigoUsuario = codigoUsuario;
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }
        #endregion

    }
}

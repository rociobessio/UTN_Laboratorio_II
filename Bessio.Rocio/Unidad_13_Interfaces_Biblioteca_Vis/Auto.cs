using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Vis
{
    public class Auto : Vehiculo
    {
        #region ATRIBUTOS
        protected string patente;
        #endregion

        #region METODOS

        #region CONSTRUCTOR
        public Auto(double precio, string patente) : base(precio)
        {
            this.patente = patente;
        }
        #endregion

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
           // sb.AppendLine(base.MostrarPrecio());
            sb.AppendLine($"Precio vehiculo: {this.patente}");
        }
        #endregion

    }
}

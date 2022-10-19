using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Vis
{
    public abstract class Vehiculo
    {
        #region ATRIBUTOS
        protected double precio;
        #endregion

        #region METODOS
        #region CONSTRUCTORES
        public Vehiculo(double precio)
        {
            this.precio = precio;
        }
        #endregion
        
        public void MostrarPrecio()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Precio vehiculo: {this.precio}"); 
        }
        #endregion
    }
}

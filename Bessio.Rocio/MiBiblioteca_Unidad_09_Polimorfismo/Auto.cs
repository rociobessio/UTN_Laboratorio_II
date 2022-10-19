using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_Unidad_09_Polimorfismo
{
    public class Auto : Vehiculo
    {
        #region ATRIBUTOS
        protected int cantAsientos;
        #endregion

        #region CONSTRUCTOR
        public Auto(string patente,Byte cantRuedas,EMarcas marca,int cantAsientos) 
            : base (patente,cantRuedas,marca)
        {
            this.cantAsientos = cantAsientos;
        }
        #endregion

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CANT. ASIENTOS: {this.cantAsientos}");
            return sb.ToString();
        }

    }
}

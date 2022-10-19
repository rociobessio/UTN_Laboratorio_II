using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_Unidad_09_Polimorfismo
{
    public class Camion : Vehiculo
    {
        #region ATRIBUTOS
        protected float tara;
        #endregion

        #region CONSTRUCTOR
        public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara)
            : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        #endregion

        #region METODOS
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TARA: {this.tara}");
            return sb.ToString();
        }
        #endregion
    }
}

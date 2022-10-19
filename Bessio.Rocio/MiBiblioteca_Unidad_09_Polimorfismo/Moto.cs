using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_Unidad_09_Polimorfismo
{
    public class Moto : Vehiculo
    {
        #region ATRIBUTOS
        protected float cilindrada;
        #endregion

        #region CONSTRUCTOR
        public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada)
            : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region METODOS
        public string MostrarMoto ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"CILINDRADA: {this.cilindrada}");
            return sb.ToString();
        }
        #endregion

    }
}

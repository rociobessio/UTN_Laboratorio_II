using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_EnciendanMotores_Unidad_08
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region ATRIBUTOS 
        private short cilindrada;
        #endregion

        #region PROPIEDADES 
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR QUE HEREDA TANTO NUMERO COMO ESCUDERIA DE LA CLASE PADRE
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        public MotoCross(short numero, string escuderia) : base(numero, escuderia) { }

        /// <summary>
        /// CONSTRUCTOR QUE HEREDA NUMERO Y ESCUDERIA 
        /// Y ASIGNA CILINDRADA
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        /// <param name="cilindrada"></param>
        public MotoCross(short numero, string escuderia, short cilindrada)
            : base(numero, escuderia) { this.cilindrada = cilindrada; }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS MotoCross SERAN IGUALES SI COINCIDE CUANDO, ADEMAS DE COINCIDIR LOS DATOS CONTENIDOS
        /// EN VehiculoCarrera, COINCIDA CON EL ATRIBUTO cilidrada.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (MotoCross m1,MotoCross m2)
        {
            bool esNull = false;
            if (m1 is not null && m2 is not null)
            {
                esNull = m1.Numero == m1.Numero && m1.Escuderia == m2.Escuderia && m1.cilindrada == m2.cilindrada;
            }
            else if (m1 is null && m2 is null)
                esNull = true;
            return esNull;
        }

        public static bool operator !=(MotoCross m1,MotoCross m2)
        {
            return !(m1 == m2);
        }
        #endregion

        #region METODO
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"CILINDRADA: {Cilindrada}");
            return sb.ToString();
        }
        #endregion
    }
}

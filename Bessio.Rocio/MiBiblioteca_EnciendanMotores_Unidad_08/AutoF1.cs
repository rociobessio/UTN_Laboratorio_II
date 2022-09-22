using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                          A CALENTAR MOTORES
 *                   --------------------------------
 *                     UNIDAD 06 - COLECCIONES - C02

 Consigna:
        - Al generar un auto se cargará el atributo enCompetencia como falso. Inicializar cantidadCombustible
          y vueltasRestantes en 0.
        - Dos autos serán iguales si los atributos número y escuderia son iguales.
        - Realizar los métodos getters y setters para cantidadCombustible , enCompetencia y vueltasRestantes.
 *                                                  
 */

namespace MiBiblioteca_EnciendanMotores_Unidad_08
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region ATRIBUTOS
        private short caballosDeFuerza;
        #endregion


        #region PROPIEDADES
        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }
        #endregion

        #region METODOS DE LA CLASE 
        
        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR PARAMETRIZADO DE LA CLASE QUE HEREDA LOS ATRIBUTOS DE LA CLASE PADRE
        /// EN ESTE CASO NUMERO Y ESCUDERIA
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        public AutoF1(short numero, string escuderia) :base(numero,escuderia){ }

        public AutoF1(short numero, string escuderia, short caballosFuerza) : base(numero,escuderia)
        { this.caballosDeFuerza = caballosFuerza; }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());//Muestro los datos del vehiculo
            sb.AppendLine($"\nCABALLOS DE FUERZA: {CaballosDeFuerza}");
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS AUTOF1 SERAN IGUALES CUANDO, ADEMAS DE CONINCIDIR LOS DATOS CONTENIDOS EN 
        /// VehiculoDeCarrera, COINCIDA EL ATRIBUTO caballosDeFuerza.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool esNull = false;
            if (a1 is not null && a2 is not null)
            {
                esNull = a1.Escuderia == a2.Escuderia &&    
                         a1.Numero == a2.Numero &&
                         a1.caballosDeFuerza == a2.caballosDeFuerza;
            }
            else if (a1 is null && a2 is null)
                esNull = true;
            
            return esNull;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
        #endregion

    }
}

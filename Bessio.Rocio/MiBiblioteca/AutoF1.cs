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
namespace MiBiblioteca
{
    public class AutoF1
    {
        #region ATRIBUTOS
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region METODOS DE LA CLASE 
        /// <summary>
        /// CONSTRUCTOR PARAMETRIZADO DE LA CLASE
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="escuderia"></param>
        public AutoF1 (short numero,string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nCANTIDAD DE COMBUSTIBLE: {this.cantidadCombustible}\nEN COMPETENCIA: {this.enCompetencia}\nESCUDERIA: {this.escuderia}\nNUMERO: {this.numero}\nVUELTAS RESTANTES: {this.vueltasRestantes}\n");
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// DOS AUTOS SERAN IGUALES SI NUMERO Y ESCUDERIA SON IGUALES
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            bool esNull = false;
            if(a1 is not null && a2 is not null)
            {
                esNull =  a1.escuderia == a2.escuderia && a1.numero == a2.numero;
            }
            if(a1 is null && a2 is null)
            {
                esNull = true;
            }
            return esNull;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        #endregion

        #region PROPIEDADES (GETTERS Y SETTERS)
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
               this.enCompetencia = value;
            }
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

    #endregion

}
}

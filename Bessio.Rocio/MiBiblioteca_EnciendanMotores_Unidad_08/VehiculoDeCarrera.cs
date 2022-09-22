using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                              GO SPEED RACER, GO!
 *                            ----------------------
 *                             UNIDAD 08 - HERENCIA
 *                             
 * MODIFICACION DE LA BIBLIOTECA DEL EJERCICIO ENCIENDAN SUS MOTORES, APLICANDO 
 * HERENCIA.
 */
namespace MiBiblioteca_EnciendanMotores_Unidad_08
{
    public class VehiculoDeCarrera
    {
        #region ATRIBUTOS
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region PROPIEDADES

        #region PROPIEDADES (GETTERS Y SETTERS)
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public short VueltasRestantes
        {
            get
            { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        #endregion


        #endregion

        #region METODOS
        #region CONSTRUCTOR
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        #endregion
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nCANTIDAD DE COMBUSTIBLE: {CantidadCombustible}\nEN COMPETENCIA: {EnCompetencia}\nESCUDERIA: {Escuderia}\nNUMERO: {Numero}\nVUELTAS RESTANTES: {VueltasRestantes}\n");
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos vehiculos seran iguales si coinciden numero y escuderia
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator == (VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool esNull = false;
            if (v1 is not null && v2 is not null)
            {
                esNull = v1.escuderia == v2.escuderia && v1.numero == v2.numero;
            }
            else if (v1 is null && v2 is null)
                esNull = true;
            return esNull;
        }

        public static bool operator != (VehiculoDeCarrera v1,VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}

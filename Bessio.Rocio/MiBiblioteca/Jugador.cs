using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                          ESTADISTICA DEPORTIVA
 *                       --------------------------
 *                       UNIDAD 06 - COLECCIONES
 *                       
    Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
    El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
    MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
    Dos jugadores serán iguales si tienen el mismo DNI.
 */
namespace MiBiblioteca
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region METODOS DE CLASE

        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        /// <summary>
        /// CONSTRUCTOR PARAMETRIZADO
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        public Jugador(int dni, string nombre) : this()
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos) : this(dni,nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }
        #endregion

        /// <summary>
        /// Obtengo el promedio de los goles por partidos, podria tranquilamente haber usadp
        /// una propiedad!
        /// </summary>
        /// <returns></returns>
        public float GetPromedioGoles()
        {
            return (float)this.partidosJugados / this.totalGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"JUGADOR: {this.nombre}\nDNI: {this.dni}\nPARTIDOS JUGADOS: {this.partidosJugados}\nTOTAL GOLES: {this.totalGoles}\nPROMEDIO GOLES: {this.promedioGoles}");
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        public static bool operator == (Jugador j1,Jugador j2)
        {
           bool esNull = false;
               if (j1 is not null && j2 is not null)//Por las dudas verfico que no sea null
               {
                   esNull = j1.dni == j2.dni;
               }
               else if (j1 is null && j2 is null)
               {
                   esNull = true;
               }
               return esNull;
            //return j1.dni == j2.dni;
        }

        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion

        #endregion



    }
}

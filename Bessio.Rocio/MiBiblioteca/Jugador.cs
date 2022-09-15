using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                                   ESTADISTICA DEPORTIVA
 *                       ------------------------------------------------
 *                       UNIDAD 06 y 07 - COLECCIONES Y ENCAPSULAMIENTO
 *                                        EJERCICIO C01
 *                       
 * CONSIGNA UNIDAD 06:
------------------------
        - Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
        - El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
        - MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        - Dos jugadores serán iguales si tienen el mismo DNI.
 
 CONSIGNA UNIDAD 07:
---------------------
        - Partir del ejercicio Estadística deportiva y realizar los siguientes cambios:
        - Agregar propiedades de sólo lectura a los atributos partidosJugados, promedioGoles y
          totalGoles de Jugador, y de lectura/escritura a nombre y dni.
        - Quitar el atributo promedioGoles de jugador. Calcular dicho promedio dentro de la 
          propiedad de sólo lectura PromedioDeGoles.
        - Quitar el método GetPromedioGoles, colocando dicha lógica en la respectiva propiedad.
        - Realizar todos los cambios necesarios para que vuelva a funcionar como antes.
 
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

        #region PROPIEDADES
        #region DE LECTURA (unicamente get)
        public int PartidosJugador
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles/this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        #endregion
        #region DE LECTURA Y ESCRITURA (con get y set)
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        #endregion

        #endregion

        /// <summary>
        /// Obtengo el promedio de los goles por partidos, podria tranquilamente haber usadp
        /// una propiedad!
        /// </summary>
        /// <returns></returns>
        /*public float GetPromedioGoles()
        {
            return (float)this.partidosJugados / this.totalGoles;
        }*/
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"JUGADOR: {this.nombre}\nDNI: {this.dni}\nPARTIDOS JUGADOS: {this.partidosJugados}\nTOTAL GOLES: {this.totalGoles}\nPROMEDIO GOLES: {this.PromedioGoles.ToString()}");
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

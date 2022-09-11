using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                              EL EJEMPLO UNIVERSAL
 *                        ------------------------------
 *                        UNIDAD 03 - CLASES - EJER. I03
 * 
 */


namespace MiBiblioteca
{
    public class Estudiante
    {

        #region DECLARACION DE ATRIBUTOS
        //Atributo ESTATICO de tipo Random
        private static Random random;
        //Atributos de INSTANCIA:
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private float promedioNotas;
        private int notaFinal;
        #endregion


        #region CONSTRUCTORES
        /// <summary>
        /// CONSTRUCTOR ESTATICO QUE INICIALIZARA EL ATRIBUTO ESTATICO RANDOM
        /// </summary>
        static Estudiante()
        { //Tengo que instanciar el atributo de tipo Random
            Estudiante.random = new Random();
        }

        /// <summary>
        /// INICIALIZA LOS ATRIBUTOS DE INSTANCIA DE LA CLASE ESTUDIANTE
        /// </summary>
        /// <param name="nombre">Se pasa el nombre para inicializarlo</param>
        /// <param name="apellido">Se pasa el apellido para inicializarlo</param>
        /// <param name="legajo">Se pasa el legajo para inicializarlo</param>
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.promedioNotas = 0;
        }
        #endregion

        #region METODOS
        #region SETTERS
        /// <summary>
        /// HACEMOS UN SETTER DEL SEGUNDO PARCIAL
        /// </summary>
        /// <param name="notaSegundoParcial">RECIBE LA SEGUNDA NOTA DEL PARCIAL</param>
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        /// <summary>
        /// HACEMOS UN SETTER DEL PRIMER PARCIAL
        /// </summary>
        /// <param name="notaPrimerParcial">NOS PASAN LA NOTA DEL PRIMER PARCIAL</param>
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        #endregion

        /// <summary>
        /// RETORNA EL PROMEDIO DE LAS DOS NOTAS
        /// </summary>
        /// <param name="nota1"></param>
        /// <param name="nota2"></param>
        /// <returns></returns>
        private float CalcularPromedio()
        {
            return this.notaPrimerParcial + this.notaSegundoParcial / 2.0f;//en vez de pone (float) pongo 2.0f
        }

        /// <summary>
        /// 
        /// </summary>
        public int CalcularNotaFinal()//Double ?
        {
            int notaFinal = -1;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = Estudiante.random.Next(6, 11);
            }

            return notaFinal;
        }

        /// <summary>
        /// Utilizar el StringBuilder para armar una cadena de texto con todos los datos de los alumnos
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            int notaFinal = this.CalcularNotaFinal();
            float promedio = this.CalcularPromedio();
            string notaFinalString = "";

            StringBuilder estudianteString = new StringBuilder();

            if (notaFinal == -1)
            {
                notaFinalString += "ALUMNO DESAPROBADO!";
            }
            else
            {
                notaFinalString += notaFinal.ToString();
            }

            estudianteString.AppendLine($"NOMBRE: {this.nombre} APELLIDO: {this.apellido } LEGAJO: {this.legajo}");
            estudianteString.AppendLine($"PRIMER PARCIAL: {this.notaPrimerParcial} SEGUNDO PARCIAL: {this.notaSegundoParcial} PROMEDIO: {promedio}");
            estudianteString.AppendLine($"NOTA FINAL: {notaFinalString}");

            //LA DEVUELVO COMO STRING
            return estudianteString.ToString();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_18_Eventos_Biblioteca_Ejercicio_I01
{
    #region DELEGADO
    public delegate void DelegadoString(string msg);
    #endregion

    public class Persona
    {
        #region ATRIBUTOS
        private string nombre;
        private string apellido;
        #endregion

        #region PROPIEDADES
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        #endregion

        #region CONSTRUCTOR
        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Debera retornar string con el nombre y apellido de la persona
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre} - APELLIDO: {this.apellido}");
            return sb.ToString();
        }
        #endregion

        #region EVENTOS
        public event DelegadoString EventoString;
        #endregion

    }
}

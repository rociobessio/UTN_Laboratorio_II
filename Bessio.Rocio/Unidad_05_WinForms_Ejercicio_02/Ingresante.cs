using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_05_WinForms_Ejercicio_02
{
    class Ingresante
    {
        #region ATRIBUTOS PRIVADOS DE LA CLASE
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        #endregion

        #region CONSTRUCTOR
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
        #endregion

        #region METODOS DE LA CLASE
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"EL NOMBRE ES:{this.nombre},\nLA EDAD ES:{edad},\nSU GENERO ES:{genero},\nEL PAIS ES:{pais},\nLA DIRECCION ES:{direccion},\nEL/LOS  CURSO/S: {this.cursos} ");

            return sb.ToString();
        }

        #endregion 
    }
}

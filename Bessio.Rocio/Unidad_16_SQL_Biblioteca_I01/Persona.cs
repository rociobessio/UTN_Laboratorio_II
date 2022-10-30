using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Unidad_16_SQL_Biblioteca_I01
{
    public class Persona
    {
        #region ATRIBUTOS
        private int id;
        private string nombre;
        private string apellido;
        #endregion

        #region PROPIEDADES
        public int ID { get { return this.id; } set { this.id = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        #endregion 


        #region CONSTRUCTOR

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Tendra un constrcutor que reciba los tres atributos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(int id,string nombre,string apellido) : this(nombre,apellido)
        {
            this.id = id;
        }
        #endregion

        #region METODO POLIMORFISMO 
        public override string ToString()
        {
            return $"ID: {this.id}\n" +
        $"NOMBRE: { this.nombre}\n" +
        $"APELLIDO: {this.apellido}\n";
        }
        #endregion
    }
}

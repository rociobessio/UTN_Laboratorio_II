using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    public class CentralitaExeption : Exception //La clase CentralitaExeption deriva de la clase Exeption
    {
        #region ATRIBUTOS
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region PROPIEDADES
        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }
        #endregion

        #region EXEPTIONS - CONSTRUCTORES
        public CentralitaExeption(string mensaje,Exception innerException) : base(mensaje,innerException)
        { }
        public CentralitaExeption(string mensaje) : this(mensaje,null) { }
        public CentralitaExeption (string mensaje,string clase,string metodo,Exception innerException) 
            : this(mensaje,innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }
        public CentralitaExeption(string mensaje, string clase, string metodo)
             : this(mensaje,clase,metodo, null) { }
        #endregion
    }
}

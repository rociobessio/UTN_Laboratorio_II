using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    /// <summary>
    /// Clase que hereda de Archivo.
    /// Implementar la interfaz de tipo STRING
    /// </summary>
    public class PuntoTxt<T> : Archivo,IArchivo<string>
    {
        #region PROPIEDAD
        /// <summary>
        /// Implemento la propiedad abstracta de la clase Archivo
        /// </summary>
        protected override string Extension { get { return ".txt"; } }
        #endregion      
        
        #region IMPLEMENTO METODOS DE INTERFAZ
        public void Guardar(string path, string contenido)
        {
            if (base.ValidarSiExisteElArchivo(path) && base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                this.GuardarArchivo(path, contenido);
            }
        }

        public void GuardarComo(string path, string contenido)
        {
            if (base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                this.GuardarArchivo(path, contenido);
            }
        }

        public string Leer(string path)
        {
            if (base.ValidarSiExisteElArchivo(path) && base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    return streamReader.ReadToEnd();
                }
            }
            return null;
        }
        #endregion

        #region METODO DE LA CLASE

        private void GuardarArchivo(string path, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(contenido);//Escribo
            }
        }
        #endregion
    }
}

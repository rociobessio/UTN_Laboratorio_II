using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    /// <summary>
    /// Hereda de Archivo.
    /// Sera GENERICA <T> y tendra un tipo GENERICO T que 
    /// debera ser un tipo de REFERENCIA
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PuntoXML<T> : Archivo,IArchivo<T>
        where T : class
    {
        #region PROPIEDAD
        /// <summary>
        /// Implemento la propiedad abstracta de la clase Archivo
        /// </summary>
        protected override string Extension { get { return ".xml"; } }
        #endregion
        #region IMPLEMENTO METODOS DE INTERFAZ
        public void Guardar(string path, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(path) && base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                this.Serializar(path, contenido);
            }
        }

        public void GuardarComo(string path, T contenido)
        {
            if (base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                this.Serializar(path, contenido);
            }
        }

        public T Leer(string path)
        {
            if (base.ValidarSiExisteElArchivo(path) && base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));//Serializo y que sea del tipo GENERICO T (IArchivo)
                    return xmlSerializer.Deserialize(streamReader) as T;
                }
            }
            return null;
        }
        #endregion

        #region METODO DE LA CLASE
        private void Serializar(string path, T coontenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));//Serializo y que sea del tipo GENERICO T (IArchivo)
                xmlSerializer.Serialize(streamWriter,coontenido);//Serializo

            }
        }
        #endregion
    }
}

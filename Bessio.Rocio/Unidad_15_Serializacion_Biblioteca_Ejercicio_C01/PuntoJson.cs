using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    /// <summary>
    /// La clase PuntoJson HEREDA DE ARCHIVO!
    /// Sera GENERICA y tendra un tipo GENERICO que debera de ser un tipo de REFERENCIA (CLASE)
    /// </summary>
    public class PuntoJson<T> : Archivo, IArchivo<T>
        where T : class
    {
        #region PROPIEDAD
        /// <summary>
        /// Implemento la propiedad abstracta de la clase Archivo
        /// </summary>
        protected override string Extension { get { return ".json"; } }
        #endregion

        #region IMPLEMENTO METODOS DE INTERFAZ
        public void Guardar(string path, T contenido)
        {
            if (base.ValidarSiExisteElArchivo(path) && base.ValidarExtencion(path))//De los metodos de la clase base obtengo las validaciones.
            {
                this.Serializar(path,contenido);
            }
        }

        public void GuardarComo(string path,T contenido)
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
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(json);
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
                string json = JsonSerializer.Serialize(coontenido);
                streamWriter.Write(json);
            
            }
        }
        #endregion
    }
}

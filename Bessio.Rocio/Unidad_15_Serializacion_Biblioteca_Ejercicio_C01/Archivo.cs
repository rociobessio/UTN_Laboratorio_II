using System;
using System.IO;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    public abstract class Archivo
    {
        #region PROPIEDAD
        protected abstract string Extension { get; }
        #endregion

        #region METODOS DE LA CLASE
        /// <summary>
        /// Comprueba que el path/archivo existan realmentes, si lo hace retorna true y si no una excepcion propia.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool ValidarSiExisteElArchivo(string path)
        {
            if (!File.Exists(path)) // Veo si existe el archivo
            {
                throw new ArchivoIncorrectoException("[ERROR, El archivo no fue encontrado!]");
            }
            return true;
        }
        
        /// <summary>
        /// Valida que la extension del archivo sea la que retorna la propiedad abstracta Extension. Si no lo es, retorna una 
        /// excepcion.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool ValidarExtencion(string path)
        {
            if (Path.GetExtension(path) != Extension)//Si el archivo no contiene la extension que queremos.
            {
                throw new ArchivoIncorrectoException($"[ERROR, El archivo no cuenta con extesion de tipo: {Extension}]");
            }
            return true;//Si no retorno true...
        }
        
        
        #endregion


    }
}

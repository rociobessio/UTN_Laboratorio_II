using System;
using Unidad_16_SQL_Biblioteca_I01;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Unidad_16_PruebaSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PROBAR CONEXION
            PersonaADO ado = new PersonaADO();

            if (ado.ProbarConexion())
            {
                Console.WriteLine("Se conectó!!!");
            }
            else
            {
                Console.WriteLine("No se conectó.");
            }
            #endregion

            #region GUARDAR
            Persona obj = new Persona(4,"Agustina","Beck");

            bool agrego = ado.Guardar(obj);

            if (agrego)
            {
                Console.WriteLine("Se agregó!!!");
            }
            else
            {
                Console.WriteLine("No se agregó.");
            }
            #endregion

            #region LEER
            List<Persona> listaPersonas = ado.Leer();

            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            #region LEER POR ID
            Persona persona2 = ado.LeerPorID(1);
            Console.WriteLine(persona2.ToString());
            #endregion

            #region MODIFICAR


            persona2.ID = 2;//La id que voy a modificar
            persona2.Nombre = "modificado";//Cambio el nombre
            persona2.Apellido = "Aca";//Cambio el apellido

            bool modifico = ado.Modificar(persona2);

            if (modifico)
            {
                Console.WriteLine("Se modificó!!!");
            }
            else
            {
                Console.WriteLine("No se modificó.");
            }

            listaPersonas = ado.Leer();

            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            #region BORRAR (DELETE)
            bool elimino = ado.Eliminar(4);

            if (elimino)
            {
                Console.WriteLine("Se eliminó!!!");
            }
            else
            {
                Console.WriteLine("No se eliminó.");
            }

            listaPersonas = ado.Leer();

            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

        }
    }
}

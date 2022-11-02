using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Unidad_16_SQL_Biblioteca_Ejercicio_I03
{
    public static class JuegoDAO
    {
        #region ATRIBUTOS
        private static string cadena_Conexion;
        private static SqlDataReader lector;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor estatico de la clase JuegoDAO que lo que hace es instanciar los objetos
        /// </summary>
        static JuegoDAO()
        {
            JuegoDAO.cadena_Conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Ejercicios_UTN;Data Source=DESKTOP-FFA3IJB";//La cadena para conectarse con la URL de la base de datos
            JuegoDAO.comando = new SqlCommand();//Instancio el comando
            JuegoDAO.conexion = new SqlConnection(JuegoDAO.cadena_Conexion);//Instancio lac conexion y le paso justamente la URL de la base de datos
            JuegoDAO.comando.Connection = conexion;//Al comando le paso la conexion de la url de la base de datos.
            JuegoDAO.comando.CommandType = CommandType.Text;//Setteo al comando como tipo de texto
        }

        #endregion

        #region METODOS

        #region ELIMINAR (DELETE)
        /// <summary>
        /// Elimina un juego de la tabla en base al id recibido
        /// </summary>
        /// <param name="codigoJuego"></param>
        public static void Eliminar(int codigoJuego)
        {
            try
            {
                JuegoDAO.comando = new SqlCommand();//Instancio el comando

                JuegoDAO.comando.Parameters.AddWithValue("@ID",codigoJuego);//Añado los parametros con los valores al comando para luego identificar y simplificar
                string sql = "DELETE FROM JUEGOS WHERE ID = @ID";//Escribo el comando que se va a ejecutar en la base para eliminarlo de la tabla

                JuegoDAO.comando.CommandType = CommandType.Text;//Setteo el comando como tipo texto.
                JuegoDAO.comando.CommandText = sql;//Le paso el comando
                JuegoDAO.comando.Connection = JuegoDAO.conexion;//Le paso la conexion al comando

                JuegoDAO.conexion.Open();//Abro la conexion

                JuegoDAO.comando.ExecuteNonQuery();//Me devuelve si modifica algun archivo de la tabla

                //Podria verificar si me devuelve algo pero no lo pide la consiga...

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (JuegoDAO.conexion.State == ConnectionState.Open)//Si la conexion esta abierta
                {
                    JuegoDAO.conexion.Close();//La cierro y evito problemas
                }
            }
        }
        #endregion

        #region GUARDAR (CREATE)
        /// <summary>
        /// Guarda un nuevo registro, tener en cuenta que CODIGO_JUEGO es una columna de identidad 
        /// (quiere decir, que no se debe de guardar, se asigna sola en la tabla)
        /// </summary>
        /// <param name="juego"></param>
        public static void Guardar(Juego juego)
        {
            ///Siempre un bloque try-catch-finally para atrapar excepciones y al final cerrar la conexion con la base de datos
            try
            {
                JuegoDAO.comando = new SqlCommand();//Instancio el comando

                //Añado los parametros
                JuegoDAO.comando.Parameters.AddWithValue("@CODIGO_USUARIO", juego.CodigoUsuario);
                JuegoDAO.comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre); 
                JuegoDAO.comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                JuegoDAO.comando.Parameters.AddWithValue("@GENERO", juego.Genero);

                string sql = "INSERT INTO JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO) VALUES (@CODIGO_USUARIO, @NOMBRE, @PRECIO, @GENERO)"; //Paso lo que se va a ejecutar en SQL

                JuegoDAO.comando.CommandType = CommandType.Text;//Lo seteo al comando como de tipo texto
                JuegoDAO.comando.CommandText = sql;

                JuegoDAO.comando.Connection = JuegoDAO.conexion;//Le paso la conexion al comando

                JuegoDAO.conexion.Open();//Abro la conexion

                JuegoDAO.comando.ExecuteNonQuery();//Me devuelve si modifica algun archivo de la tabla

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (JuegoDAO.conexion.State == ConnectionState.Open)//Si  la conexion esta abierta la cierro
                {
                    JuegoDAO.conexion.Close();
                }
            }
        }
        #endregion

        #region LEER (READ)
        /// <summary>
        /// Realiza una consulta a la base de datos que traiga los datos de los usuarios y sus juegos para instanciar
        /// objetos de tipo Biblioteca
        /// </summary>
        /// <returns></returns>
        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();//Instancio la lista

            //Evito excepciones con try-catch
            try
            {
                JuegoDAO.conexion.Open();//Abro la conexion con la base de datos
                JuegoDAO.comando.CommandText = "SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS. USERNAME as usuario" +
                    "FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";//UNO LAS DOS TABLAS MEDIANTE EL CODIGO DE USUARIO QUE ESTA EN CADA UNA CON EL JOIN

                using (JuegoDAO.lector = JuegoDAO.comando.ExecuteReader())//Ejecuto como reader sobre la base de datoss
                {
                    while (JuegoDAO.lector.Read())//Mientras tenga para leer...
                    {
                        bibliotecas.Add(new Biblioteca(lector["usuario"].ToString(),lector["genero"].ToString(),lector["juego"].ToString(),
                            Convert.ToInt32(lector["codigoJuego"])));
                    }
                }
            }
            finally
            {
                if (JuegoDAO.conexion.State == ConnectionState.Open)
                {
                    JuegoDAO.conexion.Close();//Cierro la conexion si esta abierta
                }
            }
            return bibliotecas;
        }
        #endregion

        #region LEER POR ID (READ)
        /// <summary>
        /// Retornara un juego de la base de datos a partir del ID recibido
        /// </summary>
        /// <param name="codigoJuego"></param>
        /// <returns></returns>
        public static Juego LeerPorID(int codigoJuego)
        {
            Juego juego = null;//La seteo como null ya que tengo un constructor parametrizado.

            try
            {
                JuegoDAO.conexion.Open();//Abro la conexion.

                JuegoDAO.comando.CommandText = $"SELECT * FORM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";//La linea a ejecutar en la base

                using (JuegoDAO.lector = JuegoDAO.comando.ExecuteReader())
                {
                    while (JuegoDAO.lector.Read())//Mientras tenga para leer
                    {
                        //Instancio el juego
                        juego = new Juego(lector["NOMBRE"].ToString(), Convert.ToDouble(lector["PRECIO"]), lector["GENERO"].ToString(),
                            Convert.ToInt32(lector["CODIGO_JUEGO"]), Convert.ToInt32(lector["CODIGO_USUARIO"]));
                    }
                }
            }
            finally
            {
                if (JuegoDAO.conexion.State == ConnectionState.Open)
                {
                    JuegoDAO.conexion.Close();
                }
            }
            return juego;
        }
        #endregion

        #region MODIFICAR (UPDATE)
        /// <summary>
        /// Modifica las columnas PRECIO, NOMBRE y GENERO de la tabla en base al id recibido
        /// </summary>
        /// <param name="juego"></param>
        public static void Modificar(Juego juego)
        {
            //Evito excepciones con un try-finally
            try
            {
                JuegoDAO.comando.Parameters.Clear();//Limpio el comando para que no hayan errores
                JuegoDAO.conexion.Open();//Abro la conexion con la base de datos

                //Realizo las modificaciones pertienentes para que la linea de comandos se pueda ejecutar en la base de datos
                JuegoDAO.comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @Nombre, GENERO = @Genero, PRECIO = @Precio" +
                    $"WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                JuegoDAO.comando.Parameters.AddWithValue("@Nombre",juego.Nombre);
                JuegoDAO.comando.Parameters.AddWithValue("@Genero",juego.Genero);
                JuegoDAO.comando.Parameters.AddWithValue("@Precio", juego.Precio);

                JuegoDAO.comando.ExecuteNonQuery();//Me fijo si se puedieron modificar los archivos
            }
            finally
            {
                if (JuegoDAO.conexion.State == ConnectionState.Open)//Si la conexion esta abierta la cierra
                {
                    JuegoDAO.conexion.Close();
                }
            }
        }
        #endregion

        #endregion
    }
}

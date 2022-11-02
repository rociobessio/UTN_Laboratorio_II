using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Unidad_16_SQL_Biblioteca_Ejercicio_I03
{
    public static class UsuarioDAO
    {
        #region ATRIBUTOS
        private static string cadena_conexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader lector;
        #endregion

        #region CONSTRUCTOR
        static UsuarioDAO()
        {
            UsuarioDAO.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Ejercicios_UTN;Data Source=DESKTOP-FFA3IJB";
            UsuarioDAO.comando = new SqlCommand();
            UsuarioDAO.conexion = new SqlConnection(cadena_conexion);
            UsuarioDAO.comando.Connection = conexion;
            UsuarioDAO.comando.CommandType = System.Data.CommandType.Text;
        }
        #endregion
        
        #region METODOS
        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuariosBase = new List<Usuario>();

            try
            {
                //Instancio el comando de tipo SqlCommand para usarlo
                UsuarioDAO.comando = new SqlCommand();
                UsuarioDAO.comando.CommandType = CommandType.Text;//Como sera interpretado el comando, en este caso, como texto
                UsuarioDAO.comando.CommandText = "SELECT * FROM USUARIOS";//Hago un select de TODA (*) la base para luego mostrarla.
                UsuarioDAO.comando.Connection = UsuarioDAO.conexion;//Settea la conexion

                UsuarioDAO.conexion.Open(); //Abro la conexion con la base de datos...

                UsuarioDAO.lector = comando.ExecuteReader();//Envia el comando a la conexion y crean el SqlReader

                //Utilizo una estructura iterativa, para acceder a los campos
                while (UsuarioDAO.lector.Read())//Mientras tenga para leer el lector en la base....
                {
                    Usuario usuario = new Usuario("",0);
                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    usuario.CodigoUsuario = (int)lector["codigo usuario"];
                   // usuario.CodigoUsuario = lector[1].ToString();

                    listaUsuariosBase.Add(usuario);//Añado a la lista, podria haber validaciones antes de guardarlo..
                }

                UsuarioDAO.lector.Close();//Cierro el lector...

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());//Si ocurrio alguna excepcion la imprimo por consola..
            }
            finally
            {
                if (UsuarioDAO.conexion.State == ConnectionState.Open)//Si la conexion con el servidor esta abierta...
                {
                    UsuarioDAO.conexion.Close();//Cierro la conexion
                }
            }

            return listaUsuariosBase;
        }
        #endregion
    }
}

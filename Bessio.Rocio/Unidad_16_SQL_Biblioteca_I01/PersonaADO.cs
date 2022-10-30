using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Unidad_16_SQL_Biblioteca_I01
{
    public class PersonaADO
    {
        #region Atributos

        private static string cadena_conexion; //Para la url de la base de datos
        private static SqlConnection conexion; //Para conectarse a la base de datos SQLServer, si no esta no puedo hacer ningun tipo de consulta.
        private static SqlCommand comando; //Para los comandos de tipo Insert, delete, update, select, etc
        private static SqlDataReader lector; //Permite recuperar las filas de un posible select y despues lo puedo mostrar

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor donde lo que hago es conectarme a la base de datos para ESTABLECER LA CONEXION
        /// </summary>
        static PersonaADO()
        {
            PersonaADO.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Mi_Primer_CRUD_I01;Data Source=DESKTOP-FFA3IJB";
            PersonaADO.comando = new SqlCommand();
            PersonaADO.conexion = new SqlConnection(cadena_conexion);
            PersonaADO.comando.Connection = conexion;
            PersonaADO.comando.CommandType = System.Data.CommandType.Text;

        }
        #endregion

        #region METODOS

        #region PROBAR CONEXION
        /// <summary>
        /// Metodo para probar la conexion con la base de datos de SQL
        /// Testear si me pude conectar o no.
        /// 
        /// Siempre Verificar que este dentro de un bloque try-catch, ya que puede
        /// haber muchas excepciones.
        /// </summary>
        /// <returns></returns>
        public bool ProbarConexion()
        {
            bool huboConexion = true;

            try
            {
                //Intento abrir la conexion, si no hubo excepcion todo bien.
                conexion.Open();
            }
            catch (Exception)
            {
                huboConexion = false;//Si hubo excepcion devuelvo false.
            }
            finally
            {
                //No puedo abrir algo que esta abierto, o cerrar algo que esta cerrado...
                if (conexion.State == ConnectionState.Open)//Chequeo el ESTADO de la la conexion, si esta abierta y la cierro...
                {
                    conexion.Close();
                }
            }
            return huboConexion;
        }
        #endregion

        #region GUARDAR (CREATE - INSERT)
        /// <summary>
        /// Guardara una persona en la base de datos
        /// </summary>
        /// <returns></returns>
        public bool Guardar(Persona persona)
        {
            bool pudoGuardar = true;

            try
            {
                //Recordar que si la ID es identidad no se debe de pasar con el insert, si no nunca la agregara a la lista
                PersonaADO.comando = new SqlCommand("INSERT INTO Persona VALUES ('" + persona.Nombre + "','"+ persona.Apellido +"')");

                //       this.comando.CommandType = CommandType.Text;
                //         this.comando.CommandText = sql;
                PersonaADO.comando.Connection = PersonaADO.conexion;

                PersonaADO.conexion.Open();

                int filasAfectadas = PersonaADO.comando.ExecuteNonQuery();
                comando.Parameters.Clear();//Limpio los parametros
                if (filasAfectadas == 0)
                {
                    pudoGuardar = false;
                }
            }
            catch (Exception)//Si se produce una excepcion
            {
                pudoGuardar = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)//Verifico si esta abierta o cerrada
                {
                    conexion.Close();
                }
            }
            return pudoGuardar;
        }
        #endregion

        #region LEER (READ - SELECT)
        /// <summary>
        /// Retornara la lista de personas de la base de datos...
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public List<Persona> Leer()
        {
            List<Persona> listaPersonasBase = new List<Persona>();

            try
            {
                //Instancio el comando de tipo SqlCommand para usarlo
                PersonaADO.comando = new SqlCommand();
                PersonaADO.comando.CommandType = CommandType.Text;//Como sera interpretado el comando, en este caso, como texto
                PersonaADO.comando.CommandText = "SELECT * FROM Persona";//Hago un select de TODA (*) la base para luego mostrarla.
                PersonaADO.comando.Connection = PersonaADO.conexion;//Settea la conexion

                PersonaADO.conexion.Open(); //Abro la conexion con la base de datos...

                PersonaADO.lector = comando.ExecuteReader();//Envia el comando a la conexion y crean el SqlReader

                //Utilizo una estructura iterativa, para acceder a los campos
                while (lector.Read())//Mientras tenga para leer el lector en la base....
                {
                    Persona persona = new Persona(0, "", "");
                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    persona.ID = (int)lector["id"];
                    persona.Nombre = lector[1].ToString();
                    persona.Apellido = lector[2].ToString();

                    listaPersonasBase.Add(persona);//Añado a la lista, podria haber validaciones antes de guardarlo..
                }

                lector.Close();//Cierro el lector...

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());//Si ocurrio alguna excepcion la imprimo por consola..
            }
            finally
            {
                if (PersonaADO.conexion.State == ConnectionState.Open)//Si la conexion con el servidor esta abierta...
                {
                    PersonaADO.conexion.Close();//Cierro la conexion
                }
            }

            return listaPersonasBase;
        }

        #endregion

        #region LEER POR ID (READ - SELECT - WHERE)
        /// <summary>
        /// Devuelve a una persona filtrandolo por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Persona LeerPorID(int id)
        {
            Persona persona = new Persona(0, "", "");
            try
            {
                //Instancio el comando de tipo SqlCommand para usarlo
                PersonaADO.comando = new SqlCommand();
                PersonaADO.comando.CommandType = CommandType.Text;//Como sera interpretado el comando, en este caso, como texto
                PersonaADO.comando.CommandText = "SELECT * FROM Persona where ID = "+id;//Hago un select de TODA (*) la base para luego mostrarla y filtar por id.
                PersonaADO.comando.Connection = PersonaADO.conexion;//Settea la conexion

                PersonaADO.conexion.Open(); //Abro la conexion con la base de datos...

                PersonaADO.lector = comando.ExecuteReader();//Envia el comando a la conexion y crean el SqlReader

                //Utilizo una estructura iterativa, para acceder a los campos
                while (lector.Read())//Mientras tenga para leer el lector en la base....
                {
                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    persona.ID = (int)lector["id"];
                    persona.Nombre = lector[1].ToString();
                    persona.Apellido = lector[2].ToString();

                 //   listaPersonasBase.Add(persona);//Añado a la lista, podria haber validaciones antes de guardarlo..
                }

                lector.Close();//Cierro el lector...

            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());//Si ocurrio alguna excepcion la imprimo por consola..
            }
            finally
            {
                if (PersonaADO.conexion.State == ConnectionState.Open)//Si la conexion con el servidor esta abierta...
                {
                    PersonaADO.conexion.Close();//Cierro la conexion
                }
            }

            return persona;
        }

        #endregion

        #region MODIFICAR (UPDATE)
        /// <summary>
        /// Modificara a una persona a partir de su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Modificar(Persona persona)
        {
            bool pudoModificar = true;
            
            try
            {
                PersonaADO.comando = new SqlCommand();//Instancio el comando

                //Añado los nuevos parametros al comando con el operador @:
                PersonaADO.comando.Parameters.AddWithValue("@ID", persona.ID);
                PersonaADO.comando.Parameters.AddWithValue("@Nombre",persona.Nombre);
                PersonaADO.comando.Parameters.AddWithValue("@Apellido",persona.Apellido);

                //Cargamos la informacion
                string sql = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido " +
                    "WHERE ID = @ID";

                PersonaADO.comando.CommandType = CommandType.Text;//Seteamos el comando como tipo texto
                PersonaADO.comando.CommandText = sql;//Agrego las lineas del UPDATE
                PersonaADO.comando.Connection = PersonaADO.conexion;//Me fijo la conexion y se la paso al comando..

                PersonaADO.conexion.Open();//Abro la conexion

                int filasAfectadas = PersonaADO.comando.ExecuteNonQuery();//Me fijo si realmente pudo hacer el UPDATE de las rows-archivos

                if (filasAfectadas == 0)
                {
                    pudoModificar = false;
                }

            }
            catch (Exception)//Lanzo excepcion
            {

                pudoModificar = false;
            }
            finally
            {
                //Cierro la conexion...
                if (PersonaADO.conexion.State == ConnectionState.Open)
                {
                    PersonaADO.conexion.Close();
                }
            }
            return pudoModificar;
        }


        #endregion

        #region BORRAR (DELETE)
        public bool Eliminar(int id)
        {
            bool pudoEliminar = true;

            try
            {
                PersonaADO.comando = new SqlCommand();//Instancio el comando

                PersonaADO.comando.Parameters.AddWithValue("@ID",id);//Seteo el valor de la id que me pasaron

                string sql = "DELETE FROM Persona WHERE ID = @ID";//Escribo el comando

                PersonaADO.comando.CommandType = CommandType.Text;
                PersonaADO.comando.CommandText = sql;//Al comando le paso lo que escribi en la string de sql
                PersonaADO.comando.Connection = PersonaADO.conexion;//Al comando le paso la conexion

                PersonaADO.conexion.Open();//Abro la conexion

                int filasAfectadas = PersonaADO.comando.ExecuteNonQuery();//Me fijo si la transaccion de datos pudo modificar la row

                if (filasAfectadas == 0)
                {
                    pudoEliminar = false;
                }
            }
            catch (Exception)
            {
                pudoEliminar = false;
            }
            finally
            {
                //Si la conexion esta abierta la cierro
                if (PersonaADO.conexion.State == ConnectionState.Open)
                {
                    PersonaADO.conexion.Close();
                }
            }

            return pudoEliminar;
        }
        #endregion

        #endregion


    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mis_base_SQL_Explicacion;Data Source=DESKTOP-FFA3IJB";
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        public List<Dato> ObtenerListaDato()
        {
            List<Dato> lista = new List<Dato>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM test";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Dato item = new Dato();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.id = (int)lector["id"];
                    item.cadena = lector[1].ToString();
                    item.entero = lector.GetInt32(2);
                    item.flotante = float.Parse(lector[3].ToString());

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert

        public bool AgregarDato(Dato param)
        {
            bool rta = true;

            try
            {
                //string sql = "INSERT INTO test (cadena, entero, flotante) VALUES(";
                //sql = sql + "'" + param.cadena + "'," + param.entero.ToString() + "," + param.flotante.ToString() + ")";
                int id = 2;

                this.comando = new SqlCommand("INSERT INTO test VALUES ("+ id.ToString() +",'" + param.cadena + "'," + param.entero.ToString() + "," + param.flotante.ToString() + ")");

         //       this.comando.CommandType = CommandType.Text;
       //         this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update

        public bool ModificarDato(Dato param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.id);
                this.comando.Parameters.AddWithValue("@cadena", param.cadena);
                this.comando.Parameters.AddWithValue("@entero", param.entero);
                this.comando.Parameters.AddWithValue("@flotante", param.flotante);

                string sql = "UPDATE test ";
                sql += "SET cadena = @cadena, entero = @entero, flotante = @flotante ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete
        /// <summary>
        /// Eliminara a una persona de la base de datos a partir de su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM test ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}

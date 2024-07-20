using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM Usuario");
                SqlCommand cmd = new SqlCommand(query.ToString(), con.conectar());
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();


                dt.Load(dr);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return new DataTable();
            }
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idCategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();

                SqlCommand cmd = new SqlCommand("RegistrarUsuario", con.conectar());
                cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("Identificador", obj.Identificador);
                cmd.Parameters.AddWithValue("Contrasena", obj.Contrasena);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

            }
            catch (Exception ex)
            {
                idCategoriagenerado = 0;
                Mensaje = ex.Message;
            }

            return idCategoriagenerado;
        }


        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                Conexion conexion = new Conexion();
                SqlCommand cmd = new SqlCommand("ModificarUsuario", conexion.conectar());
                cmd.Parameters.AddWithValue("IdUsuario", obj.Id);
                cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("Apellidos", obj.Apellidos);
                cmd.Parameters.AddWithValue("Identificador", obj.Identificador);
                cmd.Parameters.AddWithValue("Contrasena", obj.Contrasena);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                conexion.desconectar();
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }


        public bool Eliminar(int id, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Id = @IdUsuario", conexion.conectar());
                cmd.Parameters.AddWithValue("IdUsuario", id);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                respuesta = true;
                Mensaje = "Usuario eliminado correctamente";

                conexion.desconectar();
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public int Login(string usuario, string contra)
        {
            Conexion conexion = new Conexion();
            try
            {
                SqlCommand comd = new SqlCommand("SELECT * FROM Usuario WHERE Identificador = @usuario AND Contrasena = @contra;", conexion.conectar());
                comd.Parameters.AddWithValue("@usuario", usuario);
                comd.Parameters.AddWithValue("@contra", contra);

                SqlDataReader dr = comd.ExecuteReader();

                if (dr.Read())
                {
                    Logueado.Id = dr.GetInt32(0);
                    Logueado.Nombre = dr.GetString(1);
                    Logueado.Apellidos = dr.GetString(2);
                    Logueado.Identificador = dr.GetString(3);
                    Logueado.Contrasena = dr.GetString(4);
                    return 1;
                }
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            finally
            {
                conexion.desconectar();
            }
        }
    }
}

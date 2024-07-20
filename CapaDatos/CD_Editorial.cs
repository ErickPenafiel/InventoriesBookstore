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
    public class CD_Editorial
    {
        public DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM Editoriales");
                SqlCommand cmd = new SqlCommand(query.ToString(), con.conectar());
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();

                dt.Load(dr);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new DataTable();
            }
        }

        public int Registrar(Editorial obj, out string Mensaje)
        {
            int idCategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();

                SqlCommand cmd = new SqlCommand("RegistrarEditorial", con.conectar());
                cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("Correo", obj.Correo);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                con.desconectar();
            }
            catch (Exception ex)
            {
                idCategoriagenerado = 0;
                Mensaje = ex.Message;
            }

            return idCategoriagenerado;
        }
        
        public bool Editar(Editorial obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("ModificarEditorial", con.conectar());
                cmd.Parameters.AddWithValue("IdEditorial", obj.Id);
                cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("Correo", obj.Correo);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                con.desconectar();
                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
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
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("DELETE FROM Editoriales WHERE id = @IdEditorial", con.conectar());
                cmd.Parameters.AddWithValue("@IdEditorial", id);
                cmd.ExecuteNonQuery();

                respuesta = true;
                con.desconectar();
                Mensaje = "Editorial eliminada correctamente";
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public DataTable Buscar(string campo, string buscar)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM Editoriales WHERE " + campo + " LIKE '%" + buscar + "%';";
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    con.desconectar();
                    return dt;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}

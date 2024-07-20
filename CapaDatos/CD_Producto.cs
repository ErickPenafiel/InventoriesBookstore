using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Producto
    {
        public DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT Productos.Id, Productos.Codigo, Productos.Titulo, Productos.Autor, Productos.IdEditorial, Editoriales.Nombre, Productos.Cantidad, Productos.Imagen, Productos.Precio FROM Productos INNER JOIN Editoriales ON Productos.IdEditorial = Editoriales.Id WHERE Estado = 1");
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

        public int Registrar(Producto obj, out string Mensaje)
        {
            int idCategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();

                SqlCommand cmd = new SqlCommand("RegistrarProducto", con.conectar());
                cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                cmd.Parameters.AddWithValue("Titulo", obj.Titulo);
                cmd.Parameters.AddWithValue("Autor", obj.Autor);
                cmd.Parameters.AddWithValue("IdEditorial", obj.IdEditorial);
                cmd.Parameters.AddWithValue("Imagen", obj.Imagen);
                cmd.Parameters.AddWithValue("Precio", obj.Precio);
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


        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                Conexion conexion = new Conexion();
                SqlCommand cmd = new SqlCommand("ModificarProducto", conexion.conectar());
                cmd.Parameters.AddWithValue("IdProducto", obj.Id);
                cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                cmd.Parameters.AddWithValue("Titulo", obj.Titulo);
                cmd.Parameters.AddWithValue("Autor", obj.Autor);
                cmd.Parameters.AddWithValue("IdEditorial", obj.IdEditorial);
                cmd.Parameters.AddWithValue("Cantidad", obj.Cantidad);
                cmd.Parameters.AddWithValue("Imagen", obj.Imagen);
                cmd.Parameters.AddWithValue("Precio", obj.Precio);
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
                SqlCommand cmd = new SqlCommand("UPDATE Productos Set Estado = 0 WHERE Id = @IdProducto", conexion.conectar());
                cmd.Parameters.AddWithValue("IdProducto", id);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                respuesta = true;
                Mensaje = "Producto eliminado correctamente";

                conexion.desconectar();
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
                string sql = "SELECT Productos.Id, Productos.Codigo, Productos.Titulo, Productos.Autor, Productos.IdEditorial, Editoriales.Nombre, Productos.Cantidad FROM Productos INNER JOIN Editoriales ON Productos.IdEditorial = Editoriales.Id WHERE " + campo + " LIKE '%" + buscar + "%' AND Estado = 1;";
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

        public int ObtenerStock(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT Cantidad FROM Productos WHERE Id = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int stock = Convert.ToInt32(dr["Cantidad"].ToString());
                    con.desconectar();
                    return stock;
                }
                else
                {
                    con.desconectar();
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }

        }

        public string obtenerProducto(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT Titulo FROM Productos WHERE Id = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string nombre = dr["Titulo"].ToString();
                    con.desconectar();
                    return nombre;
                }
                else
                {
                    con.desconectar();
                    return "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }

        public DataTable ListarInventario()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT Productos.Id, Productos.Codigo, Productos.Titulo, Productos.Autor, Productos.IdEditorial, Editoriales.Nombre, Productos.Cantidad, Productos.Imagen, Productos.Precio FROM Productos INNER JOIN Editoriales ON Productos.IdEditorial = Editoriales.Id WHERE Productos.Cantidad > 0 AND Productos.Estado = 1");
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
    }
}

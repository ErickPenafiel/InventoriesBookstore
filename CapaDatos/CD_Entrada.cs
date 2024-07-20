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
    public class CD_Entrada
    {
        public DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT Id as 'N° Entrada', Total, Fecha FROM Entrada");
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

        public int Registrar(Entrada obj, out string Mensaje)
        {
            int idEntradaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();
                
                SqlCommand cmd = new SqlCommand("RegistrarEntrada", con.conectar());
                cmd.Parameters.AddWithValue("@Total", obj.Total);
                cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                idEntradaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                con.desconectar();
            }
            catch (Exception ex)
            {
                idEntradaGenerado = 0;
                Mensaje = ex.Message;
            }

            return idEntradaGenerado;
        }

        public int ultimoRegistro()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT MAX(Id) FROM Entrada");
                String sql = query.ToString();
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                cmd.CommandText = sql;
                int id = Convert.ToInt32(cmd.ExecuteScalar());               
                con.desconectar();
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT Id as 'N° Entrada', Total, Fecha FROM Entrada WHERE Fecha BETWEEN @FechaInicio AND @FechaFin");
                SqlCommand cmd = new SqlCommand(query.ToString(), con.conectar());
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin;
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

        public DataTable FiltrarEntradas(string fechaInicio, string fechaFin, string orderBy, string order)
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT Id as 'N° Entrada', Total, Fecha FROM Entrada WHERE Fecha BETWEEN @FechaInicio AND @FechaFin");

                if (!string.IsNullOrEmpty(orderBy) && !string.IsNullOrEmpty(order))
                {
                    query.AppendLine($"ORDER BY {orderBy} {order}");
                }
                
                SqlCommand cmd = new SqlCommand(query.ToString(), con.conectar());
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin;
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

        public int ModificarTotal(int id, double total, out string Mensaje)
        {
            int idEntradaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();

                SqlCommand cmd = new SqlCommand("ModificarTotal", con.conectar());
                cmd.Parameters.AddWithValue("@IdEntrada", id);
                cmd.Parameters.AddWithValue("@Subtotal", total);
                cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                idEntradaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                con.desconectar();
            }
            catch (Exception ex)
            {
                idEntradaGenerado = 0;
                Mensaje = ex.Message;
            }

            return idEntradaGenerado;
        }
    }
}

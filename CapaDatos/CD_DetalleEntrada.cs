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
    public class CD_DetalleEntrada
    {
        public DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT DetalleEntrada.IdEntrada as 'N° Entrada', Productos.Titulo as 'Producto', DetalleEntrada.PrecioUnitario as 'Precio Unitario', DetalleEntrada.Cantidad, DetalleEntrada.Consignacion as '% Consignacion', DetalleEntrada.MontoTotal as 'SubTotal', DetalleEntrada.Fecha  FROM DetalleEntrada INNER JOIN Entrada on DetalleEntrada.IdEntrada = Entrada.Id INNER JOIN Productos ON DetalleEntrada.IdProducto = Productos.Id");
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

        public int Registrar(DetalleEntrada obj, out string Mensaje)
        {
            int idEntradaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                Conexion con = new Conexion();

                SqlCommand cmd = new SqlCommand("RegistrarDetalleEntrada", con.conectar());
                cmd.Parameters.AddWithValue("@IdEntrada", obj.IdEntrada);
                cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);
                cmd.Parameters.AddWithValue("@PrecioUnitario", obj.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                cmd.Parameters.AddWithValue("@MontoTotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@Consignacion", obj.Consignacion);
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

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            try
            {
                Conexion con = new Conexion();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT DetalleEntrada.IdEntrada as 'N° Salida', Productos.Titulo as 'Producto', DetalleEntrada.PrecioUnitario as 'Precio Unitario', DetalleEntrada.Cantidad, DetalleEntrada.Consignacion as '% Consignacion' DetalleEntrada.MontoTotal as 'SubTotal', DetalleEntrada.Fecha  FROM DetalleEntrada INNER JOIN Entrada on DetalleEntrada.IdEntrada = Entrada.Id INNER JOIN Productos ON DetalleEntrada.IdProducto = Productos.Id WHERE DetalleEntrada.Fecha BETWEEN @FechaInicio AND @FechaFin");
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

                query.AppendLine("SELECT DetalleEntrada.IdEntrada as 'N° Salida', Productos.Titulo as 'Producto', DetalleEntrada.PrecioUnitario as 'Precio Unitario', DetalleEntrada.Cantidad, DetalleEntrada.Consignacion as '% Consignacion', DetalleEntrada.MontoTotal as 'SubTotal', DetalleEntrada.Fecha  FROM DetalleEntrada INNER JOIN Entrada on DetalleEntrada.IdEntrada = Entrada.Id INNER JOIN Productos ON DetalleEntrada.IdProducto = Productos.Id WHERE DetalleEntrada.Fecha BETWEEN @FechaInicio AND @FechaFin");

                if (!string.IsNullOrEmpty(orderBy) && !string.IsNullOrEmpty(order))
                {
                    query.AppendLine($"ORDER BY {orderBy} {order}");
                }

                SqlCommand cmd = new SqlCommand(query.ToString(), con.conectar());
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin;
                cmd.Parameters.Add("@order", SqlDbType.VarChar).Value = orderBy;
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
    }
}

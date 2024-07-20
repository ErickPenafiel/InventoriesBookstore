using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_DetalleEntrada
    {
        CD_DetalleEntrada detalleEntrada = new CD_DetalleEntrada();

        public DataTable Listar()
        {
            return detalleEntrada.Listar();
        }

        public int Registrar(DetalleEntrada obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.IdEntrada == 0) Mensaje += "Es necesario el id de la Entrada\n";
            if (obj.IdProducto == 0) Mensaje += "Es necesario el id del Producto\n";
            if (obj.Cantidad == 0) Mensaje += "Es necesario la cantidad del Producto\n";
            if (obj.Precio == 0) Mensaje += "Es necesario el precio del Producto\n";
            if (obj.Subtotal == 0) Mensaje += "Es necesario el subtotal del Producto\n";

            return Mensaje != string.Empty ? 0 : detalleEntrada.Registrar(obj, out Mensaje);
        }

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            return detalleEntrada.ListarPorFecha(fechaInicio, fechaFin);
        }

        public DataTable FiltrarEntradas(string fechaInicio, string fechaFin, string orderBy, string order)
        {
            return detalleEntrada.FiltrarEntradas(fechaInicio, fechaFin, orderBy, order);
        }
    }
}

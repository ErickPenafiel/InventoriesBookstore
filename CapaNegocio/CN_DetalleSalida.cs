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
    public class CN_DetalleSalida
    {
        CD_DetalleSalida detalleSalida = new CD_DetalleSalida();

        public DataTable Listar()
        {
            return detalleSalida.Listar();
        }

        public int Registrar(DetalleSalida obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.IdSalida == 0) Mensaje += "Es necesario el id de la Entrada\n";
            if (obj.IdProducto == 0) Mensaje += "Es necesario el id del Producto\n";
            if (obj.Cantidad == 0) Mensaje += "Es necesario la cantidad del Producto\n";
            if (obj.Precio == 0) Mensaje += "Es necesario el precio del Producto\n";
            if (obj.Subtotal == 0) Mensaje += "Es necesario el subtotal del Producto\n";

            return Mensaje != string.Empty ? 0 : detalleSalida.Registrar(obj, out Mensaje);
        }

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            return detalleSalida.ListarPorFecha(fechaInicio, fechaFin);
        }

        public DataTable FiltrarSalidas(string fechaInicio, string fechaFin, string orderBy, string order)
        {
            return detalleSalida.FiltrarSalidas(fechaInicio, fechaFin, orderBy, order);
        }
    }
}

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
    public class CN_Salida
    {
        CD_Salida salida = new CD_Salida();

        public DataTable Listar()
        {
            return salida.Listar();
        }

        public int Registrar(Salida obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Total == 0) Mensaje += "Es necesario el total de la Entrada\n";

            return Mensaje != string.Empty ? 0 : salida.Registrar(obj, out Mensaje);
        }

        public int ultimoRegistro()
        {
            return salida.ultimoRegistro();
        }

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            return salida.ListarPorFecha(fechaInicio, fechaFin);
        }

        public DataTable FiltrarSalidas(string fechaInicio, string fechaFin, string orderBy, string order)
        {
            return salida.FiltrarSalidas(fechaInicio, fechaFin, orderBy, order);
        }
    }
}

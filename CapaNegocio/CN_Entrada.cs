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
    public class CN_Entrada
    {
        CD_Entrada entrada = new CD_Entrada();

        public DataTable Listar()
        {
            return entrada.Listar();
        }

        public int Registrar(Entrada obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Total == 0) Mensaje += "Es necesario el total de la Entrada\n";

            return Mensaje != string.Empty ? 0 : entrada.Registrar(obj, out Mensaje);
        }

        public int ultimoRegistro()
        {
            return entrada.ultimoRegistro();
        }

        public DataTable ListarPorFecha(string fechaInicio, string fechaFin)
        {
            return entrada.ListarPorFecha(fechaInicio, fechaFin);
        }

        public int ModificarTotal(int id, double total, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (total == 0) Mensaje += "Es necesario el total de la Entrada\n";

            return Mensaje != string.Empty ? 0 : entrada.ModificarTotal(id, total, out Mensaje);
        }

        public DataTable FiltrarEntradas(string fechaInicio, string fechaFin, string orderBy, string order)
        {
            return entrada.FiltrarEntradas(fechaInicio, fechaFin, orderBy, order);
        }
    }
}

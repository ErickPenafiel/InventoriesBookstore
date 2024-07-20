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
    public class CN_Pedido
    {
        CD_Pedido pedido = new CD_Pedido();

        public DataTable Listar()
        {
            return pedido.Listar();
        }

        public int Registrar(Pedido obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "") Mensaje += "Es necesario el nombre de la persona que realiza el pedido\n";
            if (obj.Apellidos == "") Mensaje += "Es necesario el apellido de la persona que realiza el pedido\n";
            if (obj.Ci == "") Mensaje += "Es necesario el ci de la persona que realiza el pedido\n";
            if (obj.Telefono == "") Mensaje += "Es necesario el telefono de la persona que realiza el pedido\n";
            if (obj.Titulo == "") Mensaje += "Es necesario el titulo del libro que se desea pedir\n";
            if (obj.Autor == "") Mensaje += "Es necesario el autor del libro que se desea pedir\n";

            return Mensaje != string.Empty ? 0 : pedido.Registrar(obj, out Mensaje);
        }

        public bool Editar(Pedido obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Nombre == "") Mensaje += "Es necesario el nombre de la persona que realiza el pedido\n";
            if (obj.Apellidos == "") Mensaje += "Es necesario el apellido de la persona que realiza el pedido\n";
            if (obj.Ci == "") Mensaje += "Es necesario el ci de la persona que realiza el pedido\n";
            if (obj.Telefono == "") Mensaje += "Es necesario el telefono de la persona que realiza el pedido\n";
            if (obj.Titulo == "") Mensaje += "Es necesario el titulo del libro que se desea pedir\n";
            if (obj.Autor == "") Mensaje += "Es necesario el autor del libro que se desea pedir\n";

            return Mensaje != string.Empty ? false : pedido.Editar(obj, out Mensaje);
        }

        public bool Eliminar(int id, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (id == 0) Mensaje += "Es necesario seleccionar un pedido\n";

            return Mensaje != string.Empty ? false : pedido.Eliminar(id, out Mensaje);
        }
    }
}

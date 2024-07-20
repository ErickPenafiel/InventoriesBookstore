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
    public class CN_Editorial
    {
        CD_Editorial editorial = new CD_Editorial();

        public DataTable Listar()
        {
            return editorial.Listar();
        }

        public int Registrar(Editorial obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "") Mensaje += "Es necesario el nombre de la Editorial\n";
            if (obj.Telefono == "") Mensaje += "Es necesario el telefono de la Editorial\n";
            if (obj.Direccion == "") Mensaje += "Es necesario la direccion de la Editorial\n";
            if (obj.Correo == "") Mensaje += "Es necesario el correo de la Editorial\n";

            return Mensaje != string.Empty ? 0 : editorial.Registrar(obj, out Mensaje);
        }

        public bool Editar(Editorial obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "") Mensaje += "Es necesario el nombre de la Editorial\n";
            if (obj.Telefono == "") Mensaje += "Es necesario el telefono de la Editorial\n";
            if (obj.Direccion == "") Mensaje += "Es necesario la direccion de la Editorial\n";
            if (obj.Correo == "") Mensaje += "Es necesario el correo de la Editorial\n";

            return Mensaje != string.Empty ? false : editorial.Editar(obj, out Mensaje);
        }
        
        public bool Eliminar(int id, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (id == 0) Mensaje += "Es necesario seleccionar una editorial\n";

            return Mensaje != string.Empty ? false : editorial.Eliminar(id, out Mensaje);
        }

        public DataTable Buscar(string campo, string busqueda)
        {
            if(busqueda == "") return Listar();
            return editorial.Buscar(campo, busqueda);
        }
    }
}

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
    public class CN_Usuario
    {
        private CD_Usuario usuario = new CD_Usuario();

        public DataTable Listar()
        {
            return usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if(obj.Nombre == "") Mensaje += "Es necesario el nombre del Usuario\n";
            if (obj.Apellidos == "") Mensaje += "Es necesario el apellido del Usuario\n";
            if (obj.Identificador == "") Mensaje += "Es necesario el identificador del Usuario\n";
            if (obj.Contrasena == "") Mensaje += "Es necesario la contraseña del Usuario\n";

            return Mensaje != string.Empty ? 0 : usuario.Registrar(obj, out Mensaje);
        }


        public bool Editar(Usuario obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Nombre == "") Mensaje += "Es necesario el nombre del Usuario\n";
            if (obj.Apellidos == "") Mensaje += "Es necesario el apellido del Usuario\n";
            if (obj.Identificador == "") Mensaje += "Es necesario el identificador del Usuario\n";
            if (obj.Contrasena == "") Mensaje += "Es necesario la contraseña del Usuario\n";

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return usuario.Editar(obj, out Mensaje);
            }
        }


        public bool Eliminar(int id, out string Mensaje)
        {
            return usuario.Eliminar(id, out Mensaje);
        }

        public int Login(string usuario, string contrasena)
        {
            return this.usuario.Login(usuario, contrasena);
        }   
    }
}

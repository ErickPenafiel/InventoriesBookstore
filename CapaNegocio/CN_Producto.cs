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
    public class CN_Producto
    {
        private CD_Producto producto = new CD_Producto();


        public DataTable Listar()
        {
            return producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "") Mensaje += "Es necesario el codigo del Producto\n";
            if (obj.Titulo == "") Mensaje += "Es necesario el nombre del Producto\n";
            if (obj.Autor == "") Mensaje += "Es necesario la Descripcion del Producto\n";
            Mensaje += obj.IdEditorial == 0 ? "Es necesario la Editorial del Producto\n" : string.Empty;
            if (obj.Precio == 0) Mensaje += "Es necesario el Precio del Producto\n";

            return Mensaje != string.Empty ? 0 : producto.Registrar(obj, out Mensaje);
        }


        public bool Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.Codigo == "") Mensaje += "Es necesario el codigo del Producto\n";
            if (obj.Titulo == "") Mensaje += "Es necesario el nombre del Producto\n";
            if (obj.Autor == "") Mensaje += "Es necesario la Descripcion del Producto\n";
            if (obj.IdEditorial == 0) Mensaje += "Es necesario la Editorial del Producto\n";

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return producto.Editar(obj, out Mensaje);
            }
        }


        public bool Eliminar(int id, out string Mensaje)
        {
            return producto.Eliminar(id, out Mensaje);
        }

        public DataTable Buscar(string campo, string busqueda)
        {
            if (busqueda == "") return Listar();
            return producto.Buscar(campo, busqueda);
        }

        public int ObtenerStock(int id)
        {
            return producto.ObtenerStock(id);
        }

        public string ObtenerProducto(int id)
        {
            return producto.obtenerProducto(id);
        }

        public DataTable ListarInventario()
        {
            return producto.ListarInventario();
        }
    }
}

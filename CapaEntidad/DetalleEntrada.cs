using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleEntrada
    {
        private int id;
        private int idEntrada;
        private int idProducto;
        private int cantidad;
        private double precio;
        private double consignacion;
        private double subtotal;

        public DetalleEntrada() { }

        public DetalleEntrada(int id, int idEntrada, int idProducto, int cantidad, double precio, double subtotal)
        {
            this.Id = id;
            this.IdEntrada = idEntrada;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Subtotal = subtotal;
        }

        public int Id { get => id; set => id = value; }
        public int IdEntrada { get => idEntrada; set => idEntrada = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Consignacion { get => consignacion; set => consignacion = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
    }
}

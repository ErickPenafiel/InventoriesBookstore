using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleSalida
    {
        private int id;
        private int idSalida;
        private int idProducto;
        private int cantidad;
        private double precio;
        private double subtotal;

        public DetalleSalida() { }

        public DetalleSalida(int id, int idSalida, int idProducto, int cantidad, double precio, double subtotal)
        {
            this.Id = id;
            this.IdSalida = idSalida;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Subtotal = subtotal;
        }

        public int Id { get => id; set => id = value; }
        public int IdSalida { get => idSalida; set => idSalida = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }

    }
}

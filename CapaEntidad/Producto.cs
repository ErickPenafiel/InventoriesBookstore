using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        private int id;
        private string codigo;
        private string titulo;
        private string autor;
        private int idEditorial;
        private int cantidad;
        private byte[] imagen;
        private double precio;

        public Producto() {}

        public int Id { get => id; set => id = value; }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}

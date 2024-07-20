using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedido
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string ci;
        private string telefono;
        private string titulo;
        private string autor;

        public Pedido() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Ci { get => ci; set => ci = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellidos;
        private string identificador;
        private string contrasena;

        public Usuario() {}

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

    }
}

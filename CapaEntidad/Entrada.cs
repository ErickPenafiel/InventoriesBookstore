using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Entrada
    {
        private int id;
        private double total;

        public Entrada()
        {
        }


        public int Id { get => id; set => id = value; }
        public double Total { get => total; set => total = value; }
    }
}

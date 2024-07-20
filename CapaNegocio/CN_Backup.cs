using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Backup
    {
        public bool RealizarBackup(string rutaBackup)
        {
            try
            {
                CapaDatos.Conexion con = new CapaDatos.Conexion();
                return con.RealizarBackup(rutaBackup);
            }
            catch (Exception e)
            {
                throw new Exception("Error al realizar el backup: " + e.Message);
            }
        }
    }
}

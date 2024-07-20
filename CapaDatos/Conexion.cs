using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace CapaDatos
{
    public class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message, "Error Inesperado", MessageBoxButtons.OK);
            }
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public SqlConnection desconectar()
        {
            try
            {
                con.Close();
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool RealizarBackup(string rutaBackup)
        {
            try
            {
                string directorio = Path.GetDirectoryName(rutaBackup);
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                string backupQuery = $"BACKUP DATABASE [{con.Database}] TO DISK = '{rutaBackup}'";
                using (SqlCommand command = new SqlCommand(backupQuery, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

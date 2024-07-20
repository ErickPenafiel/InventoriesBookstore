using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosLibreria
{
    public partial class FormUsuarios : Form
    {
        CN_Usuario usuario = new CN_Usuario();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            textNombre.Text = "";
            textApellidos.Text = "";
            textIdentificador.Text = "";
            textContrasena.Text = "";
            textId.Text = "0";
            textConfContrasena.Text = "";
        }

        private void obtenerDatos()
        {
            DataTable datos = usuario.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataUsuarios.DataSource = datos.DefaultView;
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (textId.Text == "0")
            {
                if(textContrasena.Text != textConfContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                } else
                {
                    usuario.Registrar(new Usuario()
                    {
                        Nombre = textNombre.Text,
                        Apellidos = textApellidos.Text,
                        Identificador = textIdentificador.Text,
                        Contrasena = textContrasena.Text
                    }, out mensaje);
                }
            }
            else
            {
                if(textContrasena.Text != textConfContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                    return;
                } else
                {
                    usuario.Editar(new Usuario()
                    {
                        Id = Convert.ToInt32(textId.Text),
                        Nombre = textNombre.Text,
                        Apellidos = textApellidos.Text,
                        Identificador = textIdentificador.Text,
                        Contrasena = textContrasena.Text
                    }, out mensaje);
                }
            }
            MessageBox.Show(mensaje);
            obtenerDatos();
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (textId.Text == "0")
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
            else
            {
                usuario.Eliminar(Convert.ToInt32(textId.Text), out mensaje);
                MessageBox.Show(mensaje);
                obtenerDatos();
                limpiarCampos();
            }
        }

        private void dataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.Text = dataUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombre.Text = dataUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                textApellidos.Text = dataUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                textIdentificador.Text = dataUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                textContrasena.Text = dataUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

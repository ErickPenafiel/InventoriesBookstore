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
    public partial class FormEditoriales : Form
    {
        CN_Editorial editorial = new CN_Editorial();
        public FormEditoriales()
        {
            InitializeComponent();
        }

        public void obtenerDatos()
        {
            DataTable datos = editorial.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataEditoriales.DataSource = datos.DefaultView;
            }
        }

        public void limpiarCampos()
        {
            textId.Text = "0";
            textNombre.Text = "";
            textTelefono.Text = "";
            textDireccion.Text = "";
            textCorreo.Text = "";
        }

        private void FormEditoriales_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if(textId.Text == "0")
            {
                editorial.Registrar(new Editorial()
                {
                    Nombre = textNombre.Text,
                    Telefono = textTelefono.Text,
                    Direccion = textDireccion.Text,
                    Correo = textCorreo.Text
                }, out mensaje);

                MessageBox.Show(mensaje);
                obtenerDatos();
            } 
            else
            {
                editorial.Editar(new Editorial()
                {
                    Id = Convert.ToInt32(textId.Text),
                    Nombre = textNombre.Text,
                    Telefono = textTelefono.Text,
                    Direccion = textDireccion.Text,
                    Correo = textCorreo.Text
                }, out mensaje);

                MessageBox.Show(mensaje);
                obtenerDatos();
            }
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dataEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.Text = dataEditoriales.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombre.Text = dataEditoriales.Rows[e.RowIndex].Cells[1].Value.ToString();
                textTelefono.Text = dataEditoriales.Rows[e.RowIndex].Cells[2].Value.ToString();
                textDireccion.Text = dataEditoriales.Rows[e.RowIndex].Cells[3].Value.ToString();
                textCorreo.Text = dataEditoriales.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
                Console.WriteLine(ex.Message);
            }
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
                editorial.Eliminar(Convert.ToInt32(textId.Text), out mensaje);
                MessageBox.Show(mensaje);
                obtenerDatos();
                limpiarCampos();
            }
        }
    }
}

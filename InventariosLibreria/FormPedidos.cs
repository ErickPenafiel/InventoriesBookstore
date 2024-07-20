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
    public partial class FormPedidos : Form
    {
        CN_Pedido pedido = new CN_Pedido();

        public FormPedidos()
        {
            InitializeComponent();
        }

        public void obtenerDatos()
        {
            DataTable datos = pedido.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataPedidos.DataSource = datos.DefaultView;
            }
        }

        public void limpiarCampos()
        {
            textId.Text = "0";
            textNombre.Text = "";
            textApellidos.Text = "";
            textCI.Text = "";
            textTelefono.Text = "";
            textTitulo.Text = "";
            textAutor.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (textId.Text == "0")
            {
                pedido.Registrar(new Pedido()
                {
                    Nombre = textNombre.Text,
                    Apellidos = textApellidos.Text,
                    Ci = textCI.Text,
                    Telefono = textTelefono.Text,
                    Titulo = textTitulo.Text,
                    Autor = textAutor.Text
                }, out mensaje);
            }
            else
            {
                pedido.Editar(new Pedido()
                {
                    Id = Convert.ToInt32(textId.Text),
                    Nombre = textNombre.Text,
                    Apellidos = textApellidos.Text,
                    Ci = textCI.Text,
                    Telefono = textTelefono.Text,
                    Titulo = textTitulo.Text,
                    Autor = textAutor.Text
                }, out mensaje);
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
                pedido.Eliminar(Convert.ToInt32(textId.Text), out mensaje);
                MessageBox.Show(mensaje);
                obtenerDatos();
                limpiarCampos();
            }
        }

        private void dataPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.Text = dataPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombre.Text = dataPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();
                textApellidos.Text = dataPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();
                textCI.Text = dataPedidos.Rows[e.RowIndex].Cells[3].Value.ToString();
                textTelefono.Text = dataPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
                textTitulo.Text = dataPedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
                textAutor.Text = dataPedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar una fila");
                Console.WriteLine(ex.Message);
            }
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }
    }
}

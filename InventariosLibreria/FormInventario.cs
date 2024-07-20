using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosLibreria
{
    public partial class FormInventario : Form
    {
        CN_Producto producto = new CN_Producto();
        public FormInventario()
        {
            InitializeComponent();
        }

        public void obtenerDatos()
        {
            DataTable datos = producto.ListarInventario();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataInventario.DataSource = datos.DefaultView;
                dataInventario.Columns[0].Visible = false;
                dataInventario.Columns[4].Visible = false;
                dataInventario.Columns[7].Visible = false;

                DataGridViewButtonColumn btnVerImagen = new DataGridViewButtonColumn();
                btnVerImagen.Name = "VerImagen";
                btnVerImagen.HeaderText = "Ver Imagen";
                btnVerImagen.Text = "Ver";
                btnVerImagen.UseColumnTextForButtonValue = true;
                dataInventario.Columns.Add(btnVerImagen);

            }
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }



        private void MostrarImagenModal(Image rutaImagen)
        {
            Form formularioImagen = new Form();
            formularioImagen.Size = new Size(800, 600);
            formularioImagen.StartPosition = FormStartPosition.CenterScreen;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = rutaImagen;
            formularioImagen.Controls.Add(pictureBox);

            formularioImagen.ShowDialog();
        }

        private void dataInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataInventario.Columns["VerImagen"].Index && e.RowIndex >= 0)
            {
                if (dataInventario.Rows[e.RowIndex].Cells[8].Value.ToString() == String.Empty || dataInventario.Rows[e.RowIndex].Cells[8].Value.ToString() == "System.Byte[]")
                {
                    MessageBox.Show("No hay imagen disponible");
                    return;
                }
                byte[] img = (byte[])dataInventario.Rows[e.RowIndex].Cells[8].Value;
                MemoryStream ms = new MemoryStream(img);
                var image = Image.FromStream(ms);
                MostrarImagenModal(image);
            }
        }
    }
}

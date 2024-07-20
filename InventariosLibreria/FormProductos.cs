using CapaEntidad;
using CapaNegocio;
using InventariosLibreria.Modal;
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
using static System.Net.Mime.MediaTypeNames;

namespace InventariosLibreria
{
    public partial class FormProductos : Form
    {
        CN_Producto producto = new CN_Producto();

        public FormProductos()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            DataTable datos = producto.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataProductos.DataSource = datos.DefaultView;
                dataProductos.Columns[0].Visible = false;
                dataProductos.Columns[4].Visible = false;
                dataProductos.Columns[7].Visible = false;
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void limpiarCampos()
        {
            textId.Text = "0";
            textCodigo.Text = "";
            textTitulo.Text = "";
            textAutor.Text = "";
            textIdEditorial.Text = "0";
            textEditorial.Text = "";
            textCantidad.Text = "0";
            pictureImage.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalEditoriales())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textIdEditorial.Text = modal.ObEditorial.Id.ToString();
                    textEditorial.Text = modal.ObEditorial.Nombre.ToString();
                }
                else
                {
                    textEditorial.Select();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            byte[] aByte;
            if (pictureImage.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                aByte = ms.ToArray();
            }
            else
            {
                aByte = new byte[0];
            }
            
            if (textId.Text == "0")
            {
                producto.Registrar(new Producto()
                {
                    Codigo = textCodigo.Text,
                    Titulo = textTitulo.Text,
                    Autor = textAutor.Text,
                    IdEditorial = Convert.ToInt32(textIdEditorial.Text),
                    Imagen = aByte,
                    Precio = Convert.ToDouble(textPrecio.Text)
                }, out mensaje);       
            }
            else
            {
                producto.Editar(new Producto()
                {
                    Id = Convert.ToInt32(textId.Text),
                    Codigo = textCodigo.Text,
                    Titulo = textTitulo.Text,
                    Autor = textAutor.Text,
                    IdEditorial = Convert.ToInt32(textIdEditorial.Text),
                    Cantidad = Convert.ToInt32(textCantidad.Text),
                    Imagen = aByte,
                    Precio = Convert.ToDouble(textPrecio.Text)
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
                producto.Eliminar(Convert.ToInt32(textId.Text), out mensaje);
                MessageBox.Show(mensaje);
                obtenerDatos();
                limpiarCampos();
            }
        }

        private void dataProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.Text = dataProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                textCodigo.Text = dataProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                textTitulo.Text = dataProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                textAutor.Text = dataProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                textIdEditorial.Text = dataProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                textEditorial.Text = dataProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                textCantidad.Text = dataProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                byte[] img = (byte[])dataProductos.Rows[e.RowIndex].Cells[7].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureImage.Image = System.Drawing.Image.FromStream(ms);
                textPrecio.Text = dataProductos.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            openFileImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)|*.jpg;*.jpeg;*.png";
            openFileImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileImage.Title = "Seleccione una imagen";

            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                pictureImage.Image = System.Drawing.Image.FromFile(openFileImage.FileName); ;
            }
        }

        private void openFileImage_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

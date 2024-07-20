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

namespace InventariosLibreria.Modal
{
    public partial class ModalProductos : Form
    {
        CN_Producto producto = new CN_Producto();

        internal Producto obProducto = new Producto();

        internal Producto ObProducto { get => obProducto; set => obProducto = value; }
        public ModalProductos()
        {
            InitializeComponent();
        }

        public void obtenerDatos()
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
                dataProductos.Columns[8].Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                obtenerDatos();
            }
            else
            {
                DataTable datos = producto.Buscar(comboCampos.SelectedValue.ToString(), textBuscar.Text.Trim());
                if (datos == null)
                {
                    MessageBox.Show("No se logro acceder a los datos");
                }
                else
                {
                    dataProductos.DataSource = datos.DefaultView;
                }
            }
        }

        private void ModalProductos_Load(object sender, EventArgs e)
        {
            DataTable datos = new DataTable("Nombre");
            datos.Columns.Add("Nombre");
            datos.Columns.Add("Columna");
            datos.Rows.Add("Codigo", "Productos.Codigo");
            datos.Rows.Add("Titulo", "Productos.Titulo");
            datos.Rows.Add("Autor", "Productos.Autor");
            datos.Rows.Add("Editorial", "Editoriales.Nombre");
            datos.Rows.Add("Cantidad", "Productos.Cantidad");

            comboCampos.DataSource = datos;
            comboCampos.DisplayMember = "Nombre";
            comboCampos.ValueMember = "Columna";

            obtenerDatos();
        }

        private void dataProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolumn = e.ColumnIndex;

            if (irow >= 0 && icolumn > 0)
            {
                DataGridViewRow row = this.dataProductos.Rows[irow];
                ObProducto.Id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                ObProducto.Codigo = row.Cells["codigo"].Value.ToString();
                ObProducto.Titulo = row.Cells["titulo"].Value.ToString();
                ObProducto.Autor = row.Cells["autor"].Value.ToString();
                ObProducto.IdEditorial = Convert.ToInt32(row.Cells["idEditorial"].Value.ToString());
                ObProducto.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                obtenerDatos();
            }
            else
            {
                DataTable datos = producto.Buscar(comboCampos.SelectedValue.ToString(), textBuscar.Text.Trim());
                if (datos == null)
                {
                    dataProductos.DataSource = null;
                }
                else
                {
                    dataProductos.DataSource = datos.DefaultView;
                }
            }
        }
    }
}

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
    public partial class ModalEditoriales : Form
    {
        CN_Editorial editorial = new CN_Editorial();

        private Editorial obEditorial = new Editorial();
        internal Editorial ObEditorial { get => obEditorial; set => obEditorial = value; }

        public ModalEditoriales()
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

        private void ModalEditoriales_Load(object sender, EventArgs e)
        {
            comboCampos.SelectedIndex = 0;           
            obtenerDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(textBuscar.Text == "")
            {
                obtenerDatos();
            }
            else
            {
                DataTable datos = editorial.Buscar(comboCampos.SelectedItem.ToString(), textBuscar.Text.Trim());
                if (datos == null)
                {
                    MessageBox.Show("No se logro acceder a los datos");
                }
                else
                {
                    dataEditoriales.DataSource = datos.DefaultView;
                }
            }
        }

        private void dataEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolumn = e.ColumnIndex;

            if (irow >= 0 && icolumn > 0)
            {
                DataGridViewRow row = this.dataEditoriales.Rows[irow];
                ObEditorial.Id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                ObEditorial.Nombre = row.Cells["nombre"].Value.ToString();
                ObEditorial.Telefono = row.Cells["telefono"].Value.ToString();
                ObEditorial.Direccion = row.Cells["direccion"].Value.ToString();
                ObEditorial.Correo = row.Cells["correo"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable datos = editorial.Buscar(comboCampos.SelectedItem.ToString(), textBuscar.Text.Trim());
            if (datos == null)
            {
                dataEditoriales.DataSource = null;
            }
            else
            {
                dataEditoriales.DataSource = datos.DefaultView;
            }
        }
    }
}

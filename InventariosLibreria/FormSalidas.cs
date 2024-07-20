using CapaEntidad;
using CapaNegocio;
using InventariosLibreria.Modal;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class FormSalidas : Form
    {
        List<DetalleSalida> salida = new List<DetalleSalida>();
        CN_Salida oSalida = new CN_Salida();
        CN_DetalleSalida oDetalleSalida = new CN_DetalleSalida();
        CN_Producto oProducto = new CN_Producto();
        DataTable dtProductos;
        double total = 0;

        public void Alert(string msg, FormNotificaciones.enmType type)
        {
            FormNotificaciones frm = new FormNotificaciones();
            frm.showAlert(msg, type);
        }

        public FormSalidas()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            DataTable datos = oSalida.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataListaSalidas.DataSource = datos.DefaultView;
            }
        }

        private void obtenerDatosDetalle()
        {
            DataTable datos = oDetalleSalida.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataDetalleSalidas.DataSource = datos.DefaultView;
            }
        }

        public void limpiarProductos()
        {
            textIdLibro.Text = "";
            textTitulo.Text = "";
            textAutor.Text = "";
            textPrecio.Text = "";
            textCantidad.Text = "0";
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            dtProductos = new DataTable();

            dtProductos.Columns.Add("Nombre", typeof(string));
            dtProductos.Columns.Add("Cantidad", typeof(int));
            dtProductos.Columns.Add("Precio", typeof(double));
            dtProductos.Columns.Add("SubTotal", typeof(double));

            dataEntrada.DataSource = dtProductos;

            textTotal.Text = total.ToString() + " Bs.";

            obtenerDatos();
            obtenerDatosDetalle();
            dateFin.MinDate = dateInicio.Value.AddDays(1);
            dateFin.Value = dateInicio.Value.AddDays(1);
            dateFinDetalle.MinDate = dateInicioDetalle.Value.AddDays(1);
            dateFinDetalle.Value = dateInicioDetalle.Value.AddDays(1);

            Dictionary<string, string> orderByValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Nombre", "Productos.Titulo" },
                { "Cantidad", "DetalleSalida.Cantidad" },
                { "Precio", "DetalleSalida.PrecioUnitario" },
                { "SubTotal", "DetalleSalida.MontoTotal" },
                { "Fecha", "DetalleSalida.Fecha" }
            };

            comboOrderByDet.DisplayMember = "Key";
            comboOrderByDet.ValueMember = "Value";
            comboOrderByDet.DataSource = new BindingSource(orderByValues, null);

            Dictionary<string, string> orderByEntradasValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Total", "Total" },
                { "Fecha", "Fecha" }
            };

            comboOrderBy.DisplayMember = "Key";
            comboOrderBy.ValueMember = "Value";
            comboOrderBy.DataSource = new BindingSource(orderByEntradasValues, null);

            Dictionary<string, string> orderAscDesValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Ascendente", "ASC" },
                { "Descendente", "DESC" }
            };

            // Para comboOrderAscDes
            comboOrder.DisplayMember = "Key";
            comboOrder.ValueMember = "Value";
            comboOrder.DataSource = new BindingSource(orderAscDesValues, null);

            comboOrderDet.DisplayMember = "Key";
            comboOrderDet.ValueMember = "Value";
            comboOrderDet.DataSource = new BindingSource(orderAscDesValues, null);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textIdLibro.Text = modal.ObProducto.Id.ToString();
                    textTitulo.Text = modal.ObProducto.Titulo.ToString();
                    textAutor.Text = modal.ObProducto.Autor.ToString();

                    textCantidad.Focus();
                }
                else
                {
                    textTitulo.Select();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textPrecio.Text == "") MessageBox.Show("Debe ingresar un precio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (textCantidad.Text == "0") MessageBox.Show("Debe ingresar una cantidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (textIdLibro.Text == "" || textTitulo.Text == "" || textAutor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DetalleSalida detalleSalida = new DetalleSalida();

                detalleSalida.IdProducto = Convert.ToInt32(textIdLibro.Text);
                detalleSalida.Cantidad = Convert.ToInt32(textCantidad.Text);
                detalleSalida.Precio = Convert.ToDouble(textPrecio.Text);
                detalleSalida.Subtotal = detalleSalida.Cantidad * detalleSalida.Precio;

                salida.Add(detalleSalida);
                dtProductos.Rows.Add(textTitulo.Text.Trim(), detalleSalida.Cantidad, detalleSalida.Precio, detalleSalida.Subtotal);
                total = total + detalleSalida.Subtotal;
                textTotal.Text = total.ToString() + " Bs.";
            }

            
            limpiarProductos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (salida == null)
            {
                MessageBox.Show("Debe agregar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                try
                {
                    int idSalida = oSalida.Registrar(new Salida()
                    {
                        Total = total
                    }, out string mensaje);

                    idSalida = oSalida.ultimoRegistro();

                    if (idSalida != 0)
                    {
                        foreach (DetalleSalida detalle in salida)
                        {
                            detalle.IdSalida = idSalida;
                            oDetalleSalida.Registrar(detalle, out mensaje);
                            if (oProducto.ObtenerStock(detalle.IdProducto) < 1)
                            {
                                string nombreProducto = oProducto.ObtenerProducto(detalle.IdProducto);
                                this.Alert("El stock del producto " + nombreProducto + " se termino", FormNotificaciones.enmType.Error);
                            }
                            else if(oProducto.ObtenerStock(detalle.IdProducto) <= 2)
                            {
                                string nombreProducto = oProducto.ObtenerProducto(detalle.IdProducto);
                                this.Alert("El stock del producto " + nombreProducto + " esta por terminarse", FormNotificaciones.enmType.Warning);
                            }
                        }
                        salida.Clear();
                        dtProductos.Clear();
                        obtenerDatos();
                        obtenerDatosDetalle();
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarProductos();
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            dateFin.MinDate = dateInicio.Value.AddDays(1);
            dateFin.Value = dateInicio.Value.AddDays(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*DataTable data = oSalida.ListarPorFecha(dateInicio.Value.ToString("dd/MM/yyyy"), dateFin.Value.ToString("dd/MM/yyyy"));*/
            DataTable data = oSalida.FiltrarSalidas(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"), comboOrderBy.SelectedValue.ToString(), comboOrder.SelectedValue.ToString());

            if (data == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataListaSalidas.DataSource = data.DefaultView;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog pdfProductos = new SaveFileDialog();
            pdfProductos.FileName = "Salidas_" + DateTime.Now.ToString("d_MM_yyyy_HH_mm_ss") + ".pdf";
            pdfProductos.Filter = "PDF (*.pdf)|*.pdf";

            string filas = String.Empty;
            string pagina = Properties.Resources.pdfSalidas.ToString();

            pagina = pagina.Replace("@Titulo", "Reporte de Salidas");
            pagina = pagina.Replace("@Fecha", DateTime.Now.ToString("d/MM/yyyy"));

            int totalFilas = dataListaSalidas.Rows.Count;
            for (int i = 0; i < totalFilas - 1; i++)
            {
                DataGridViewRow dataGridViewRow = dataListaSalidas.Rows[i];
                filas += "<tr>";
                filas += "<td>" + dataGridViewRow.Cells["Id"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Total"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Fecha"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            pagina = pagina.Replace("@Filas", filas);

            if (pdfProductos.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(pdfProductos.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.LETTER.Rotate(), 25, 25, 25, 25);

                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdf, file);

                    pdf.Open();
                    pdf.Add(new Phrase(""));

                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_Libreria, System.Drawing.Imaging.ImageFormat.Png);
                    imagen.ScaleToFit(150, 100);
                    imagen.Alignment = iTextSharp.text.Image.UNDERLYING;
                    imagen.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 90);
                    pdf.Add(imagen);

                    using (StringReader stringReader = new StringReader(pagina))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdf, stringReader);
                    }

                    pdf.Close();

                    file.Close();

                    MessageBox.Show("PDF Creado Correctamente");
                }
            }
        }

        private void btnBorrarFiltros_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*DataTable data = oDetalleSalida.ListarPorFecha(dateInicioDetalle.Value.ToString("dd/MM/yyyy"), dateFinDetalle.Value.ToString("dd/MM/yyyy"));*/
            DataTable data = oDetalleSalida.FiltrarSalidas(dateInicioDetalle.Value.ToString("yyyy-MM-dd"), dateFinDetalle.Value.ToString("yyyy-MM-dd"), comboOrderByDet.SelectedValue.ToString(), comboOrderDet.SelectedValue.ToString());

            if (data == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataDetalleSalidas.DataSource = data.DefaultView;
            }
        }

        private void btnPdfDetalle_Click(object sender, EventArgs e)
        {
            SaveFileDialog pdfProductos = new SaveFileDialog();
            pdfProductos.FileName = "DetalleSalidas_" + DateTime.Now.ToString("d_MM_yyyy_HH_mm_ss") + ".pdf";
            pdfProductos.Filter = "PDF (*.pdf)|*.pdf";

            string filas = String.Empty;
            string pagina = Properties.Resources.pdfDetalleSalidas.ToString();

            pagina = pagina.Replace("@Titulo", "Reporte de Detalle de Salidas");
            pagina = pagina.Replace("@Fecha", DateTime.Now.ToString("d/MM/yyyy"));

            int totalFilas = dataDetalleSalidas.Rows.Count;
            for (int i = 0; i < totalFilas - 1; i++)
            {
                DataGridViewRow dataGridViewRow = dataDetalleSalidas.Rows[i];
                filas += "<tr>";
                filas += "<td>" + dataGridViewRow.Cells["N° Salida"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Precio Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "<td>" + dataGridViewRow.Cells["Fecha"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            pagina = pagina.Replace("@Filas", filas);

            if (pdfProductos.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(pdfProductos.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.LETTER.Rotate(), 25, 25, 25, 25);

                    PdfWriter pdfWriter = PdfWriter.GetInstance(pdf, file);

                    pdf.Open();
                    pdf.Add(new Phrase(""));

                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_Libreria, System.Drawing.Imaging.ImageFormat.Png);
                    imagen.ScaleToFit(150, 100);
                    imagen.Alignment = iTextSharp.text.Image.UNDERLYING;
                    imagen.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 90);
                    pdf.Add(imagen);

                    using (StringReader stringReader = new StringReader(pagina))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(pdfWriter, pdf, stringReader);
                    }

                    pdf.Close();

                    file.Close();

                    MessageBox.Show("PDF Creado Correctamente");
                }
            }
        }

        private void btnBorrarDetFilt_Click(object sender, EventArgs e)
        {
            obtenerDatosDetalle();
        }

        private void dateInicioDetalle_ValueChanged(object sender, EventArgs e)
        {
            dateFinDetalle.MinDate = dateInicioDetalle.Value.AddDays(1);
            dateFinDetalle.Value = dateInicioDetalle.Value.AddDays(1);
        }
    }
}

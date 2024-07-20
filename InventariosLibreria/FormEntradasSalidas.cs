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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventariosLibreria
{
    public partial class FormEntradasSalidas : Form
    {
        List<DetalleEntrada> entrada = new List<DetalleEntrada>();
        CN_Entrada oEntrada = new CN_Entrada();
        CN_DetalleEntrada oDetalleEntrada = new CN_DetalleEntrada();
        CN_Producto oProducto = new CN_Producto();
        DataTable dtProductos;
        double total = 0;

        public FormEntradasSalidas()
        {
            InitializeComponent();
        }

        public void Alert(string msg, FormNotificaciones.enmType type)
        {
            FormNotificaciones frm = new FormNotificaciones();
            frm.showAlert(msg, type);
        }

        private void obtenerDatos()
        {
            DataTable datos = oEntrada.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataListaEntradas.DataSource = datos.DefaultView;
            }
        }

        private void obtenerDatosDetalle()
        {
            DataTable datos = oDetalleEntrada.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataDetalleEntradas.DataSource = datos.DefaultView;
            }
        }

        public void limpiarProductos()
        {
            textIdLibro.Text = "";
            textTitulo.Text = "";
            textAutor.Text = "";
            textPrecio.Text = "";
            textCantidad.Text = "0";
            textConsignacion.Text = "0";
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
            if (textConsignacion.Text == "") {
                MessageBox.Show("Debe ingresar un porcentaje de consignacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textConsignacion.Text = "0";
                return;
            }
            if (textIdLibro.Text == "" || textTitulo.Text == "" || textAutor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DetalleEntrada detalleEntrada = new DetalleEntrada();

                detalleEntrada.IdProducto = Convert.ToInt32(textIdLibro.Text);
                detalleEntrada.Cantidad = Convert.ToInt32(textCantidad.Text);
                detalleEntrada.Precio = Convert.ToDouble(textPrecio.Text);
                detalleEntrada.Consignacion = Convert.ToDouble(textConsignacion.Text);
                detalleEntrada.Subtotal = detalleEntrada.Cantidad * detalleEntrada.Precio;

                entrada.Add(detalleEntrada);
                dtProductos.Rows.Add(textTitulo.Text.Trim(), detalleEntrada.Cantidad, detalleEntrada.Precio, detalleEntrada.Consignacion, detalleEntrada.Subtotal);
                total = total + detalleEntrada.Subtotal;
                textTotal.Text = total.ToString() + " Bs.";
            }

            limpiarProductos();
        }

        private void FormEntradasSalidas_Load(object sender, EventArgs e)
        {
            dtProductos = new DataTable();

            dtProductos.Columns.Add("Nombre", typeof(string));
            dtProductos.Columns.Add("Cantidad", typeof(int));
            dtProductos.Columns.Add("Precio", typeof(double));
            dtProductos.Columns.Add("% Consignacion", typeof(double));
            dtProductos.Columns.Add("SubTotal", typeof(double));

            dataEntrada.DataSource = dtProductos;

            textTotal.Text = total.ToString() + " Bs.";

            obtenerDatos();
            obtenerDatosDetalle();
            dateFin.MinDate = dateInicio.Value.AddDays(1);
            dateFin.Value = dateInicio.Value.AddDays(1);

            // Para comboOrderBy con sus respectivos valores
            Dictionary<string, string> orderByValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Nombre", "Productos.Titulo" },
                { "Cantidad", "DetalleEntrada.Cantidad" },
                { "Precio", "DetalleEntrada.PrecioUnitario" },
                { "SubTotal", "DetalleEntrada.MontoTotal" },
                { "Fecha", "DetalleEntrada.Fecha" }
            };

            comboOrderBy.DisplayMember = "Key";
            comboOrderBy.ValueMember = "Value";
            comboOrderBy.DataSource = new BindingSource(orderByValues, null);

            Dictionary<string, string> orderByEntradasValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Total", "Total" },
                { "Fecha", "Fecha" }
            };

            comboOrderByEnt.DisplayMember = "Key";
            comboOrderByEnt.ValueMember = "Value";
            comboOrderByEnt.DataSource = new BindingSource(orderByEntradasValues, null);


            Dictionary<string, string> orderAscDesValues = new Dictionary<string, string>
            {
                { "--------------------", "" },
                { "Ascendente", "ASC" },
                { "Descendente", "DESC" }
            };

            // Para comboOrderAscDes
            comboOrderAscDes.DisplayMember = "Key";
            comboOrderAscDes.ValueMember = "Value";
            comboOrderAscDes.DataSource = new BindingSource(orderAscDesValues, null);

            comboOrderEnt.DisplayMember = "Key";
            comboOrderEnt.ValueMember = "Value";
            comboOrderEnt.DataSource = new BindingSource(orderAscDesValues, null);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (entrada == null)
            {
                MessageBox.Show("Debe agregar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                try
                {
                    int idEntrada = oEntrada.Registrar(new Entrada()
                    {
                        Total = total
                    }, out string mensaje);

                    idEntrada = oEntrada.ultimoRegistro();

                    if (idEntrada != 0)
                    {
                        foreach (DetalleEntrada detalle in entrada)
                        {
                            detalle.IdEntrada = idEntrada;                          
                            oDetalleEntrada.Registrar(detalle, out mensaje);

                            if (oProducto.ObtenerStock(detalle.IdProducto) > 100)
                            {
                                string nombreProducto = oProducto.ObtenerProducto(detalle.IdProducto);
                                this.Alert("El stock del producto " + nombreProducto + " esta al maximo", FormNotificaciones.enmType.Info);
                            }
                        }
                        entrada.Clear();
                        dtProductos.Clear();
                        MessageBox.Show("Registro guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el registro");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            limpiarProductos();
            obtenerDatos();
            obtenerDatosDetalle();
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
            DataTable data = oEntrada.FiltrarEntradas(dateInicio.Value.ToString("yyyy-MM-dd"), dateFin.Value.ToString("yyyy-MM-dd"), comboOrderByEnt.SelectedValue.ToString(), comboOrderEnt.SelectedValue.ToString());

            if (data == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataListaEntradas.DataSource = data.DefaultView;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog pdfProductos = new SaveFileDialog();
            pdfProductos.FileName = "Entradas_" + DateTime.Now.ToString("d_MM_yyyy_HH_mm_ss") + ".pdf";
            pdfProductos.Filter = "PDF (*.pdf)|*.pdf";

            string filas = String.Empty;
            string pagina = Properties.Resources.pdfSalidas.ToString();

            pagina = pagina.Replace("@Titulo", "Reporte de Entradas");
            pagina = pagina.Replace("@Fecha", DateTime.Now.ToString("d/MM/yyyy"));

            int totalFilas = dataListaEntradas.Rows.Count;
            for (int i = 0; i < totalFilas - 1; i++)
            {
                DataGridViewRow dataGridViewRow = dataListaEntradas.Rows[i];
                filas += "<tr>";
                filas += "<td>" + dataGridViewRow.Cells["N° Entrada"].Value.ToString() + "</td>";
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

        private void button1_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnBuscarDetalle_Click(object sender, EventArgs e)
        {            
            DataTable data = oDetalleEntrada.FiltrarEntradas(dateInicioDetalle.Value.ToString("yyyy-MM-dd"), dateFinDetalle.Value.ToString("yyyy-MM-dd"), comboOrderBy.SelectedValue.ToString(), comboOrderAscDes.SelectedValue.ToString());
            if (data == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                dataDetalleEntradas.DataSource = data.DefaultView;
            }
        }

        private void btnPdfDetalle_Click(object sender, EventArgs e)
        {
            SaveFileDialog pdfProductos = new SaveFileDialog();
            pdfProductos.FileName = "DetalleEntradas_" + DateTime.Now.ToString("d_MM_yyyy_HH_mm_ss") + ".pdf";
            pdfProductos.Filter = "PDF (*.pdf)|*.pdf";

            string filas = String.Empty;
            string pagina = Properties.Resources.pdfDetalleEntradas.ToString();

            pagina = pagina.Replace("@Titulo", "Reporte de Detalle de Entradas");
            pagina = pagina.Replace("@Fecha", DateTime.Now.ToString("d/MM/yyyy"));

            int totalFilas = dataDetalleEntradas.Rows.Count;
            for (int i = 0; i < totalFilas - 1; i++)
            {
                DataGridViewRow dataGridViewRow = dataDetalleEntradas.Rows[i];
                filas += "<tr>";
                filas += "<td>" + dataGridViewRow.Cells["N° Entrada"].Value.ToString() + "</td>";
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

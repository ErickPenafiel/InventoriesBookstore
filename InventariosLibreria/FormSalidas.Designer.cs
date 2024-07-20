namespace InventariosLibreria
{
    partial class FormSalidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataEntrada = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdLibro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLibro = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataListaSalidas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboOrder = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboOrderBy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataDetalleSalidas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboOrderDet = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboOrderByDet = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPdfDetalle = new System.Windows.Forms.Button();
            this.btnBorrarDetFilt = new System.Windows.Forms.Button();
            this.dateFinDetalle = new System.Windows.Forms.DateTimePicker();
            this.dateInicioDetalle = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaSalidas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleSalidas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEntrada
            // 
            this.dataEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntrada.Location = new System.Drawing.Point(6, 185);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.RowHeadersWidth = 51;
            this.dataEntrada.RowTemplate.Height = 24;
            this.dataEntrada.Size = new System.Drawing.Size(962, 339);
            this.dataEntrada.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 559);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.dataEntrada);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Regsitrar Salida";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(753, 93);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 35);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(753, 46);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(215, 35);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar Salida";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textIdLibro);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textAutor);
            this.groupBox1.Controls.Add(this.Autor);
            this.groupBox1.Controls.Add(this.textTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLibro);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 173);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egreso";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(470, 20);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(195, 22);
            this.textTotal.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total:";
            // 
            // textIdLibro
            // 
            this.textIdLibro.Location = new System.Drawing.Point(23, 75);
            this.textIdLibro.Name = "textIdLibro";
            this.textIdLibro.Size = new System.Drawing.Size(34, 22);
            this.textIdLibro.TabIndex = 28;
            this.textIdLibro.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(437, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 35);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(159, 131);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(195, 22);
            this.textPrecio.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Precio:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(159, 94);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(195, 22);
            this.textCantidad.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad:";
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(159, 56);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(195, 22);
            this.textAutor.TabIndex = 22;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(83, 59);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(41, 16);
            this.Autor.TabIndex = 21;
            this.Autor.Text = "Autor:";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(159, 20);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(195, 22);
            this.textTitulo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Titulo:";
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnLibro.FlatAppearance.BorderSize = 0;
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(437, 69);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(215, 35);
            this.btnLibro.TabIndex = 18;
            this.btnLibro.Text = "Seleccionar Libro";
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataListaSalidas);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de Salidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataListaSalidas
            // 
            this.dataListaSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaSalidas.Location = new System.Drawing.Point(6, 175);
            this.dataListaSalidas.Name = "dataListaSalidas";
            this.dataListaSalidas.RowHeadersWidth = 51;
            this.dataListaSalidas.RowTemplate.Height = 24;
            this.dataListaSalidas.Size = new System.Drawing.Size(962, 349);
            this.dataListaSalidas.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboOrder);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboOrderBy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.btnBorrarFiltros);
            this.groupBox2.Controls.Add(this.dateFin);
            this.groupBox2.Controls.Add(this.dateInicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 163);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // comboOrder
            // 
            this.comboOrder.FormattingEnabled = true;
            this.comboOrder.Location = new System.Drawing.Point(285, 125);
            this.comboOrder.Name = "comboOrder";
            this.comboOrder.Size = new System.Drawing.Size(270, 24);
            this.comboOrder.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ordenar de manera:";
            // 
            // comboOrderBy
            // 
            this.comboOrderBy.FormattingEnabled = true;
            this.comboOrderBy.Location = new System.Drawing.Point(285, 94);
            this.comboOrderBy.Name = "comboOrderBy";
            this.comboOrderBy.Size = new System.Drawing.Size(270, 24);
            this.comboOrderBy.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ordenar por:";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(614, 68);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(215, 35);
            this.btnPdf.TabIndex = 7;
            this.btnPdf.Text = "Generar Informe";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnBorrarFiltros
            // 
            this.btnBorrarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnBorrarFiltros.FlatAppearance.BorderSize = 0;
            this.btnBorrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnBorrarFiltros.Location = new System.Drawing.Point(614, 111);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(215, 35);
            this.btnBorrarFiltros.TabIndex = 6;
            this.btnBorrarFiltros.Text = "Borrar Filtros";
            this.btnBorrarFiltros.UseVisualStyleBackColor = false;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.btnBorrarFiltros_Click);
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(285, 63);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(270, 22);
            this.dateFin.TabIndex = 5;
            // 
            // dateInicio
            // 
            this.dateInicio.Location = new System.Drawing.Point(285, 35);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(270, 22);
            this.dateInicio.TabIndex = 4;
            this.dateInicio.ValueChanged += new System.EventHandler(this.dateInicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de Finalizacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Inicio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(614, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(215, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataDetalleSalidas);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(974, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Detalle Salidas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataDetalleSalidas
            // 
            this.dataDetalleSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetalleSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalleSalidas.Location = new System.Drawing.Point(6, 175);
            this.dataDetalleSalidas.Name = "dataDetalleSalidas";
            this.dataDetalleSalidas.RowHeadersWidth = 51;
            this.dataDetalleSalidas.RowTemplate.Height = 24;
            this.dataDetalleSalidas.Size = new System.Drawing.Size(962, 349);
            this.dataDetalleSalidas.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboOrderDet);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboOrderByDet);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnPdfDetalle);
            this.groupBox3.Controls.Add(this.btnBorrarDetFilt);
            this.groupBox3.Controls.Add(this.dateFinDetalle);
            this.groupBox3.Controls.Add(this.dateInicioDetalle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(961, 163);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // comboOrderDet
            // 
            this.comboOrderDet.FormattingEnabled = true;
            this.comboOrderDet.Location = new System.Drawing.Point(285, 124);
            this.comboOrderDet.Name = "comboOrderDet";
            this.comboOrderDet.Size = new System.Drawing.Size(270, 24);
            this.comboOrderDet.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ordenar de manera:";
            // 
            // comboOrderByDet
            // 
            this.comboOrderByDet.FormattingEnabled = true;
            this.comboOrderByDet.Location = new System.Drawing.Point(285, 93);
            this.comboOrderByDet.Name = "comboOrderByDet";
            this.comboOrderByDet.Size = new System.Drawing.Size(270, 24);
            this.comboOrderByDet.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Ordenar por:";
            // 
            // btnPdfDetalle
            // 
            this.btnPdfDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnPdfDetalle.FlatAppearance.BorderSize = 0;
            this.btnPdfDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdfDetalle.ForeColor = System.Drawing.Color.White;
            this.btnPdfDetalle.Location = new System.Drawing.Point(614, 68);
            this.btnPdfDetalle.Name = "btnPdfDetalle";
            this.btnPdfDetalle.Size = new System.Drawing.Size(215, 35);
            this.btnPdfDetalle.TabIndex = 7;
            this.btnPdfDetalle.Text = "Generar Informe";
            this.btnPdfDetalle.UseVisualStyleBackColor = false;
            this.btnPdfDetalle.Click += new System.EventHandler(this.btnPdfDetalle_Click);
            // 
            // btnBorrarDetFilt
            // 
            this.btnBorrarDetFilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnBorrarDetFilt.FlatAppearance.BorderSize = 0;
            this.btnBorrarDetFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarDetFilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDetFilt.ForeColor = System.Drawing.Color.White;
            this.btnBorrarDetFilt.Location = new System.Drawing.Point(614, 111);
            this.btnBorrarDetFilt.Name = "btnBorrarDetFilt";
            this.btnBorrarDetFilt.Size = new System.Drawing.Size(215, 35);
            this.btnBorrarDetFilt.TabIndex = 6;
            this.btnBorrarDetFilt.Text = "Borrar Filtros";
            this.btnBorrarDetFilt.UseVisualStyleBackColor = false;
            this.btnBorrarDetFilt.Click += new System.EventHandler(this.btnBorrarDetFilt_Click);
            // 
            // dateFinDetalle
            // 
            this.dateFinDetalle.Location = new System.Drawing.Point(285, 63);
            this.dateFinDetalle.Name = "dateFinDetalle";
            this.dateFinDetalle.Size = new System.Drawing.Size(270, 22);
            this.dateFinDetalle.TabIndex = 5;
            // 
            // dateInicioDetalle
            // 
            this.dateInicioDetalle.Location = new System.Drawing.Point(285, 35);
            this.dateInicioDetalle.Name = "dateInicioDetalle";
            this.dateInicioDetalle.Size = new System.Drawing.Size(270, 22);
            this.dateInicioDetalle.TabIndex = 4;
            this.dateInicioDetalle.ValueChanged += new System.EventHandler(this.dateInicioDetalle_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha de Finalizacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fecha de Inicio:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(614, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 584);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalidas";
            this.Text = "FormSalidas";
            this.Load += new System.EventHandler(this.FormSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaSalidas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleSalidas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEntrada;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataListaSalidas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdLibro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrarFiltros;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataDetalleSalidas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPdfDetalle;
        private System.Windows.Forms.Button btnBorrarDetFilt;
        private System.Windows.Forms.DateTimePicker dateFinDetalle;
        private System.Windows.Forms.DateTimePicker dateInicioDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboOrderBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboOrderDet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboOrderByDet;
        private System.Windows.Forms.Label label14;
    }
}
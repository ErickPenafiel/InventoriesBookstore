namespace InventariosLibreria
{
    partial class FormEntradasSalidas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataEntrada = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textConsignacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
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
            this.dataListaEntradas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboOrderEnt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboOrderByEnt = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataDetalleEntradas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboOrderAscDes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboOrderBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPdfDetalle = new System.Windows.Forms.Button();
            this.btnBorrarDetFilt = new System.Windows.Forms.Button();
            this.dateFinDetalle = new System.Windows.Forms.DateTimePicker();
            this.dateInicioDetalle = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarDetalle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEntradas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleEntradas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataEntrada);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Regsitrar Entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textConsignacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.btnRegistrar);
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
            this.groupBox1.Size = new System.Drawing.Size(962, 173);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(398, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(306, 37);
            this.label10.TabIndex = 33;
            this.label10.Text = "Si el porcentaje de consignacion es 0, entonces no se dejara como consignacion";
            // 
            // textConsignacion
            // 
            this.textConsignacion.Location = new System.Drawing.Point(509, 20);
            this.textConsignacion.Name = "textConsignacion";
            this.textConsignacion.Size = new System.Drawing.Size(195, 22);
            this.textConsignacion.TabIndex = 32;
            this.textConsignacion.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "% Consignacion:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(741, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 35);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(509, 92);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(195, 22);
            this.textTotal.TabIndex = 30;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(741, 23);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(215, 35);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar Ingreso";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 95);
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
            this.btnAgregar.Location = new System.Drawing.Point(741, 125);
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
            this.textAutor.ReadOnly = true;
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
            this.textTitulo.ReadOnly = true;
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
            this.btnLibro.Location = new System.Drawing.Point(425, 125);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(215, 35);
            this.btnLibro.TabIndex = 18;
            this.btnLibro.Text = "Seleccionar Libro";
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataListaEntradas);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataListaEntradas
            // 
            this.dataListaEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEntradas.Location = new System.Drawing.Point(6, 179);
            this.dataListaEntradas.Name = "dataListaEntradas";
            this.dataListaEntradas.RowHeadersWidth = 51;
            this.dataListaEntradas.RowTemplate.Height = 24;
            this.dataListaEntradas.Size = new System.Drawing.Size(962, 345);
            this.dataListaEntradas.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboOrderEnt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboOrderByEnt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateFin);
            this.groupBox2.Controls.Add(this.dateInicio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 167);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // comboOrderEnt
            // 
            this.comboOrderEnt.FormattingEnabled = true;
            this.comboOrderEnt.Location = new System.Drawing.Point(285, 124);
            this.comboOrderEnt.Name = "comboOrderEnt";
            this.comboOrderEnt.Size = new System.Drawing.Size(270, 24);
            this.comboOrderEnt.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ordenar de manera:";
            // 
            // comboOrderByEnt
            // 
            this.comboOrderByEnt.FormattingEnabled = true;
            this.comboOrderByEnt.Location = new System.Drawing.Point(285, 93);
            this.comboOrderByEnt.Name = "comboOrderByEnt";
            this.comboOrderByEnt.Size = new System.Drawing.Size(270, 24);
            this.comboOrderByEnt.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Ordenar por:";
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(614, 70);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(215, 35);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "Generar Informe";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(614, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borrar Filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(285, 65);
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
            this.label6.Location = new System.Drawing.Point(125, 70);
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
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
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
            this.tabPage3.Controls.Add(this.dataDetalleEntradas);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(974, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Detalle de Entradas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataDetalleEntradas
            // 
            this.dataDetalleEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetalleEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalleEntradas.Location = new System.Drawing.Point(6, 175);
            this.dataDetalleEntradas.Name = "dataDetalleEntradas";
            this.dataDetalleEntradas.RowHeadersWidth = 51;
            this.dataDetalleEntradas.RowTemplate.Height = 24;
            this.dataDetalleEntradas.Size = new System.Drawing.Size(962, 349);
            this.dataDetalleEntradas.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboOrderAscDes);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboOrderBy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnPdfDetalle);
            this.groupBox3.Controls.Add(this.btnBorrarDetFilt);
            this.groupBox3.Controls.Add(this.dateFinDetalle);
            this.groupBox3.Controls.Add(this.dateInicioDetalle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnBuscarDetalle);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(961, 163);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // comboOrderAscDes
            // 
            this.comboOrderAscDes.FormattingEnabled = true;
            this.comboOrderAscDes.Location = new System.Drawing.Point(242, 127);
            this.comboOrderAscDes.Name = "comboOrderAscDes";
            this.comboOrderAscDes.Size = new System.Drawing.Size(270, 24);
            this.comboOrderAscDes.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ordenar de manera:";
            // 
            // comboOrderBy
            // 
            this.comboOrderBy.FormattingEnabled = true;
            this.comboOrderBy.Location = new System.Drawing.Point(242, 96);
            this.comboOrderBy.Name = "comboOrderBy";
            this.comboOrderBy.Size = new System.Drawing.Size(270, 24);
            this.comboOrderBy.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ordenar por:";
            // 
            // btnPdfDetalle
            // 
            this.btnPdfDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
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
            this.btnBorrarDetFilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
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
            this.dateFinDetalle.Location = new System.Drawing.Point(242, 62);
            this.dateFinDetalle.Name = "dateFinDetalle";
            this.dateFinDetalle.Size = new System.Drawing.Size(270, 22);
            this.dateFinDetalle.TabIndex = 5;
            // 
            // dateInicioDetalle
            // 
            this.dateInicioDetalle.Location = new System.Drawing.Point(242, 31);
            this.dateInicioDetalle.Name = "dateInicioDetalle";
            this.dateInicioDetalle.Size = new System.Drawing.Size(270, 22);
            this.dateInicioDetalle.TabIndex = 4;
            this.dateInicioDetalle.ValueChanged += new System.EventHandler(this.dateInicioDetalle_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha de Finalizacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fecha de Inicio:";
            // 
            // btnBuscarDetalle
            // 
            this.btnBuscarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnBuscarDetalle.FlatAppearance.BorderSize = 0;
            this.btnBuscarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDetalle.Location = new System.Drawing.Point(614, 27);
            this.btnBuscarDetalle.Name = "btnBuscarDetalle";
            this.btnBuscarDetalle.Size = new System.Drawing.Size(215, 35);
            this.btnBuscarDetalle.TabIndex = 1;
            this.btnBuscarDetalle.Text = "Buscar";
            this.btnBuscarDetalle.UseVisualStyleBackColor = false;
            this.btnBuscarDetalle.Click += new System.EventHandler(this.btnBuscarDetalle_Click);
            // 
            // FormEntradasSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 584);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntradasSalidas";
            this.Text = "FormEntradasSalidas";
            this.Load += new System.EventHandler(this.FormEntradasSalidas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEntradas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalleEntradas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataEntrada;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textIdLibro;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataListaEntradas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataDetalleEntradas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPdfDetalle;
        private System.Windows.Forms.Button btnBorrarDetFilt;
        private System.Windows.Forms.DateTimePicker dateFinDetalle;
        private System.Windows.Forms.DateTimePicker dateInicioDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textConsignacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboOrderAscDes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboOrderBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboOrderEnt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboOrderByEnt;
        private System.Windows.Forms.Label label14;
    }
}
namespace InventariosLibreria
{
    partial class FormProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textIdEditorial = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textIdEditorial);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textEditorial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textAutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textTitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(478, 123);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(185, 22);
            this.textPrecio.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio:";
            // 
            // textIdEditorial
            // 
            this.textIdEditorial.Location = new System.Drawing.Point(18, 79);
            this.textIdEditorial.Name = "textIdEditorial";
            this.textIdEditorial.Size = new System.Drawing.Size(40, 22);
            this.textIdEditorial.TabIndex = 15;
            this.textIdEditorial.Text = "0";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(18, 37);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(40, 22);
            this.textId.TabIndex = 14;
            this.textId.Text = "0";
            this.textId.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(686, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "Editorial";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(166, 123);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(185, 22);
            this.textCantidad.TabIndex = 12;
            this.textCantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad:";
            // 
            // textEditorial
            // 
            this.textEditorial.Location = new System.Drawing.Point(478, 79);
            this.textEditorial.Name = "textEditorial";
            this.textEditorial.Size = new System.Drawing.Size(185, 22);
            this.textEditorial.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editorial:";
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(166, 79);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(185, 22);
            this.textAutor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autor:";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(478, 37);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(185, 22);
            this.textTitulo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(166, 37);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(185, 22);
            this.textCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(809, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(809, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 30);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(809, 33);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataProductos
            // 
            this.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Location = new System.Drawing.Point(12, 188);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.RowHeadersWidth = 51;
            this.dataProductos.RowTemplate.Height = 24;
            this.dataProductos.Size = new System.Drawing.Size(763, 418);
            this.dataProductos.TabIndex = 9;
            this.dataProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductos_CellClick);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(170)))), ((int)(((byte)(114)))));
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCargarImagen.Location = new System.Drawing.Point(821, 576);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(146, 30);
            this.btnCargarImagen.TabIndex = 16;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pictureImage
            // 
            this.pictureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureImage.Location = new System.Drawing.Point(781, 188);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(214, 382);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImage.TabIndex = 17;
            this.pictureImage.TabStop = false;
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileImage";
            this.openFileImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileImage_FileOk);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 618);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdEditorial;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label6;
    }
}
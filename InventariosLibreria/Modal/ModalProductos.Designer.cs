namespace InventariosLibreria.Modal
{
    partial class ModalProductos
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
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.comboCampos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataProductos
            // 
            this.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Location = new System.Drawing.Point(13, 116);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.RowHeadersWidth = 51;
            this.dataProductos.RowTemplate.Height = 24;
            this.dataProductos.Size = new System.Drawing.Size(775, 322);
            this.dataProductos.TabIndex = 3;
            this.dataProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBuscar);
            this.groupBox1.Controls.Add(this.comboCampos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(609, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(254, 52);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(321, 22);
            this.textBuscar.TabIndex = 1;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // comboCampos
            // 
            this.comboCampos.FormattingEnabled = true;
            this.comboCampos.Items.AddRange(new object[] {
            "Codigo",
            "Titulo",
            "Autor"});
            this.comboCampos.Location = new System.Drawing.Point(104, 50);
            this.comboCampos.Name = "comboCampos";
            this.comboCampos.Size = new System.Drawing.Size(121, 24);
            this.comboCampos.TabIndex = 0;
            // 
            // ModalProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModalProductos";
            this.Text = "ModalProductos";
            this.Load += new System.EventHandler(this.ModalProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.ComboBox comboCampos;
    }
}
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            AbrirFormEnPanel(new FormEntradasSalidas());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, e);
            label1.Text = "Bienvenido " + CapaEntidad.Logueado.Nombre + " " + CapaEntidad.Logueado.Apellidos;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(fh);
            this.panel4.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            AbrirFormEnPanel(new FormInicio());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            AbrirFormEnPanel(new FormProductos());   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            AbrirFormEnPanel(new FormPedidos());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            AbrirFormEnPanel(new FormEditoriales());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;
            AbrirFormEnPanel(new FormSalidas());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;
            AbrirFormEnPanel(new FormUsuarios());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CN_Backup cn = new CN_Backup();
            
            DateTime fecha = DateTime.Now;
            
            if(cn.RealizarBackup($"C:\\backups_inventario\\inventario_bd_{fecha.Year}_{fecha.Month}_{fecha.Day}_{fecha.Hour}_{fecha.Minute}_{fecha.Second}.bak"))
            {
                MessageBox.Show("Respaldo realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Error al realizar el respaldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Height = button9.Height;
            panel3.Top = button9.Top;
            AbrirFormEnPanel(new FormInventario());
        }
    }
}

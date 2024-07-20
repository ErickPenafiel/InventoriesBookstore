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

namespace InventariosLibreria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();

            if (textUsuario.Text == "" || textContrasena.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
            }
            else
            {
                int inicioSesion = usuario.Login(textUsuario.Text.Trim(), textContrasena.Text.Trim());
                if (inicioSesion == 1)
                {
                    MessageBox.Show("Bienvenido " + textUsuario.Text, "Inicio de Sesión", MessageBoxButtons.OK);
                    this.Hide();
                    Form1 formInicio = new Form1();
                    formInicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

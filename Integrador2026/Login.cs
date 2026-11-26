using System;
using System.Windows.Forms;
using Integrador2026.Datos;
using Microsoft.Data.SqlClient;

namespace Integrador2026
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = btnConfirmarLogin;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConfirmarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreLogin.Text.Trim();
            string clave = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool valido;
            try
            {
                valido = UsuarioDAL.Validar(usuario, clave);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos:\n" + ex.Message,
                                "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!valido)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            frmPrincipal principal = new frmPrincipal();
            principal.FormClosed += (s, args) => Close();
            principal.Show();
            Hide();
        }
    }
}

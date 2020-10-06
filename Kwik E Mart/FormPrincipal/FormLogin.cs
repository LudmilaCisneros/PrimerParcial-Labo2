using Kwik_E_Mart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string supuestoUsuario = txtBoxUser.Text;
            string supuestoPass = txtBoxPassword.Text;

            supuestoUsuario = Validaciones.AgregarMayuscula(supuestoUsuario);

            FormPrincipal formPrincipal = new FormPrincipal(this,supuestoUsuario);

            if (Negocio.usuariosPass.ContainsKey(supuestoUsuario) && Negocio.usuariosPass.ContainsValue(supuestoPass))
            {
                formPrincipal.Show();
                this.Hide();
                txtBoxUser.Text = "";
                txtBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta","Chinwenwencha",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        internal void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

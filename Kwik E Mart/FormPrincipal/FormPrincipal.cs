using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }
    }
}

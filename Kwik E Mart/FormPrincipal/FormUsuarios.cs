using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kwik_E_Mart;

namespace Formularios
{
    public partial class FormUsuarios : Form
    {
        private string usuario;
        public FormUsuarios(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            lblUser.Text = usuario;
            txtUsuarios.Text = Negocio.generarTextoUsuariosPass(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

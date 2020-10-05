using System;
using System.Media;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        FormLogin login;
        public FormPrincipal(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer player = new SoundPlayer("./apu.wav");
            player.Play();
            //sonido.SoundLocation = "Kwik E Mark\\Kwik E Mart\\FormPrincipal\\gracias-vuelvas-prontos.wav";
            //sonidoApu.Stream = apu; //.Stream = Properties.Resources.apu;
            /*sonido.Play();*/

        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias,vuelva prontoss!!!", "adiosito", MessageBoxButtons.OK);
            this.login.Show();
        }
    }
}

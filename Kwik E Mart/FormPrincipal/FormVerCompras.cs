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
    public partial class FormVerCompras : Form
    {
        public FormVerCompras()
        {
            InitializeComponent();
            dtgvVerCompras.DataSource = Negocio.listaCompras;
        }

        private void FormVerCompras_Load(object sender, EventArgs e)
        {

            //int cantCompras = Negocio.listaCompras.Count;
            //List<string> listaClientesAux = new List<string>();

            //listaClientesAux = Negocio.CargarListaClientes(cantCompras);
            //dtgvVerClientes.DataSource = listaClientesAux;
            //MessageBox.Show("cant compras:"+ cantCompras.ToString());
            //dtgvVerClientes.AutoGenerateColumns = true;
            //ActualizarDtgv(dtgvVerClientes, listaClientesAux);
        }

        //private void AgregarColumnasDtgv()
        /// <summary>
        /// Actualiza el dtgv
        /// </summary>
        /// <param name="miDtgv"></param>
        /// <param name="listaAMostrar"></param>
        private void ActualizarDtgv(DataGridView miDtgv, List<string> listaAMostrar)//Cambiar tipo de lista
        {
            miDtgv.DataSource = null;
            miDtgv.DataSource = listaAMostrar;
        }

        //private void dtgvVerClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}

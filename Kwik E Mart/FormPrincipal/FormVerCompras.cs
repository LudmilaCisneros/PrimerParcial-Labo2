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
        /// <summary>
        /// Cuando presionas el boton te actualiza en el otro dtgv el detalle de la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow filaSeleccionada = dtgvVerCompras.CurrentRow;
            DataGridViewCellCollection coleccionCeldasSelect = filaSeleccionada.Cells;

            if (filaSeleccionada.Selected == false)
            {
                MessageBox.Show("No has seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("hola");
                EncontrarYMostrarCualCompraEs(coleccionCeldasSelect);
            }
            ActualizarDtgvCompra(dtgvVerCompras, Negocio.listaCompras);

        }
        /// <summary>
        /// Encuentra cual compra es la seleccionada en el dtgvVerCompras
        /// </summary>
        /// <param name="coleccionDeCeldasSelect"></param>
        private void EncontrarYMostrarCualCompraEs(DataGridViewCellCollection filaSeleccionada)
        {
            string nombreCte = filaSeleccionada[0].ToString();//ACA
            int index = Negocio.EncontrarCompraPorNombreCte(nombreCte);

            if (index != -1)
            {
                MessageBox.Show(index.ToString());
                dtgvVerDetalleCompras.DataSource = null;
                dtgvVerDetalleCompras.DataSource = Negocio.listaCompras[index].cliente.carritoCliente;
            }

        }

        /// <summary>
        /// Actualiza el dtgv
        /// </summary>
        /// <param name="miDtgv"></param>
        /// <param name="listaAMostrar"></param>
        private void ActualizarDtgvCompra(DataGridView miDtgv, List<Compra> listaAMostrar)//Cambiar tipo de lista
        {
            miDtgv.DataSource = null;
            miDtgv.DataSource = listaAMostrar;
        }
        /// <summary>
        /// Actualiza el dtgv
        /// </summary>
        /// <param name="miDtgv"></param>
        /// <param name="listaAMostrar"></param>
        private void ActualizarDtgvProductos(DataGridView miDtgv, List<Producto> listaAMostrar)//Cambiar tipo de lista
        {
            miDtgv.DataSource = null;
            miDtgv.DataSource = listaAMostrar;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            dtgvStock.AutoGenerateColumns = true;
            dtgvStock.DataSource = Negocio.listaProductos;
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow db = dtgvStock.CurrentRow;
            DataGridViewRow filaClonada = (DataGridViewRow) db.Clone();
            //Producto productoSeleccionado = Cliente.carritoCliente.Add(new Producto((Producto)db.Clone())); INTENTOS DE AGREGAR LA ROW A LA LISTA CARRITO

            if (db.Selected == false)
            {
                MessageBox.Show("No has seleccionado", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else 
            {
                MostrarFilaSeleccionada(db);
                
            }
            /*else
            {

            }*/
            //DataGridViewRow row = this.dtgvStock.CurrentRow.value.ToString();

            // Producto productoSelecccionado = Cliente.carritoCliente.add(new Producto((Producto)row));
            //DataGridView row = dtgvStock.Rows(e);
            //dtgvStock.SelectedRows;
            //Producto seleccionado = new Producto(dtgvStock.SelectedRows.Contains);
        }
        private void MostrarFilaSeleccionada(DataGridViewRow filaSeleccionada)
        {
            dtgvCarrito.AutoGenerateColumns = true;
            dtgvCarrito.Rows.Add(filaSeleccionada);
        }

        private void dtgvStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvStock.Rows[0].Selected = false;
        }
    }
}

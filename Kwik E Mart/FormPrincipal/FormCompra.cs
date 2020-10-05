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
            DataGridViewCellCollection coleccionCeldas = db.Cells;
            bool hayStock;


            if (db.Selected == false)
            {
                MessageBox.Show("No has seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(!AgregarFilaALista(coleccionCeldas))
                {
                    MessageBox.Show("No hay stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    ActualizarDtgv(dtgvCarrito, Cliente.carritoCliente);
                    ActualizarDtgv(dtgvStock, Negocio.listaProductos);
                    
                }

            }

        }

        /// <summary>
        /// Actualiza el dtgv
        /// </summary>
        /// <param name="miDtgv"></param>
        /// <param name="listaAMostrar"></param>
        private void ActualizarDtgv(DataGridView miDtgv, List<Producto> listaAMostrar)//Cambiar tipo de lista
        {
            miDtgv.DataSource = null;
            miDtgv.DataSource = listaAMostrar;
        }


        /// <summary>
        /// Agrega la fila del drgv a la lista carrito
        /// </summary>
        /// <param name="coleccionDeCeldasSelect"></param>
        /// <returns></returns>
        private bool AgregarFilaALista(DataGridViewCellCollection coleccionDeCeldasSelect)
        {
            bool hayStock = false;
            int i;
            int auxStock;
            //PARSER
            int idProducto = int.Parse(coleccionDeCeldasSelect[0].Value.ToString());
            string nombre = coleccionDeCeldasSelect[1].Value.ToString();
            string tipo = coleccionDeCeldasSelect[2].Value.ToString();
            float precio = float.Parse(coleccionDeCeldasSelect[3].Value.ToString());
            int stock = int.Parse(coleccionDeCeldasSelect[4].Value.ToString());

            hayStock = Producto.VerificarStock(stock);
            if(hayStock)
            {
               Cliente.carritoCliente.Add(new Producto(idProducto,nombre, 1, precio, tipo));//agregar          
                i = Negocio.EncontrarIndexEnLista(Negocio.listaProductos, idProducto);
                if(i != -1)
                {
                    Negocio.listaProductos[i].Stock = stock - 1;
                    
                }
            }
            return hayStock;
        }


        private void dtgvStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvStock.Rows[0].Selected = false;
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = Cliente.CalcularTotal().ToString();
        }

        private void checkBoxSimpsons_CheckedChanged(object sender, EventArgs e)
        {
            //aplicar descuento del 13%
        }
    }
}

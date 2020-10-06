using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Kwik_E_Mart;

namespace Formularios
{
    public partial class FormCompra : Form
    {
        private bool flag;
        private string usuario;

        public FormCompra(string usuario)
        {
            InitializeComponent();
            flag = false;
            this.usuario = usuario;
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            lblUser.Text = usuario;
            dtgvStock.AutoGenerateColumns = true;
            dtgvStock.DataSource = Negocio.listaProductos;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow db = dtgvStock.CurrentRow;
            DataGridViewCellCollection coleccionCeldas = db.Cells;



            if (db.Selected == false)
            {
                MessageBox.Show("No has seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!this.AgregarFilaALista(coleccionCeldas))
                {
                    MessageBox.Show("No hay stock", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ActualizarDtgv(dtgvCarrito, Cliente.carritoCliente);
                    //dtgvCarrito.Rows[0].Selected = false;
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

            //PARSER
            int idProducto = int.Parse(coleccionDeCeldasSelect[0].Value.ToString());
            string nombre = coleccionDeCeldasSelect[1].Value.ToString();
            string tipo = coleccionDeCeldasSelect[2].Value.ToString();
            float precio = float.Parse(coleccionDeCeldasSelect[3].Value.ToString());
            int stock = int.Parse(coleccionDeCeldasSelect[4].Value.ToString());

            hayStock = Producto.VerificarStock(stock);
            if (hayStock)
            {
                Cliente.carritoCliente.Add(new Producto(idProducto, nombre, 1, precio, tipo));//agregar          
                i = Negocio.EncontrarIndexEnLista(Negocio.listaProductos, idProducto);
                if (i != -1)
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
            float totalCarrito = Cliente.CalcularTotal();
            string totalStr = "$";

            if (totalCarrito != 0)
            {
                totalStr = string.Concat(totalStr, totalCarrito.ToString());
                lblTotal.Text = totalStr;
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito", "Error", MessageBoxButtons.OK);
            }

        }

        private void checkBoxSimpsons_CheckedChanged(object sender, EventArgs e)
        {
            string totalStr = lblTotal.Text.ToString();
            totalStr = Validaciones.SacarSignoPeso(totalStr);
            float totalFloatSinDesc, totalFloatConDesc;
            float.TryParse(totalStr, out totalFloatSinDesc);


            if (flag == false && checkBoxSimpsons.Checked && Validaciones.EsNumerico(totalStr))
            {
                Cliente.simpsons = true;
                flag = true;
                totalFloatConDesc = totalFloatSinDesc * 0.87f;
                totalStr = Validaciones.PonerSignoPeso(totalFloatConDesc.ToString());
                lblTotal.Text = totalStr;
            }
            else if (checkBoxSimpsons.Checked == false && Validaciones.EsNumerico(totalStr))
            {
                totalFloatSinDesc = Validaciones.Sacar13PorcAumento(totalFloatSinDesc);
                lblTotal.Text = Validaciones.PonerSignoPeso(totalFloatSinDesc.ToString());

            }

        }

        private void btnHacerCompra_Click(object sender, EventArgs e)
        {
            string totalStr = lblTotal.Text.ToString();
            totalStr = Validaciones.SacarSignoPeso(totalStr);
            DialogResult respuesta;
            StringBuilder sb = new StringBuilder();

            if (Validaciones.EsNumerico(totalStr))
            {
                respuesta = MessageBox.Show("¿Quiere confirmar la compra?", "Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (respuesta == DialogResult.OK)
                {
                    this.guardarArchivo();
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("Todavia no añadió productos", "Error", MessageBoxButtons.OK);
            }
        }
        private void guardarArchivo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "ticket";
            saveFileDialog.Filter = "Documentos de texto (.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                {
                    sw.WriteLine(this.generarTextoTicket());
                    sw.Close();
                }
            }
            else 
            {
                MessageBox.Show("Operación cancelada", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private string generarTextoTicket() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("(͡ ° ᴥ ͡ °) |°KWIK E MART°| (｡◕‿‿◕｡)\n", this.usuario);
            sb.AppendFormat("***Vendedor: {0}***\n", this.usuario);
            sb.AppendFormat("   *.Productos.*\n");

            foreach(Producto producto in Cliente.carritoCliente)
            {
                sb.Append(producto.ImprimirProducto());
                sb.AppendLine("-------------------");
            }
            sb.AppendFormat("TOTAL: {0}\n", lblTotal.Text.ToString());
            if(checkBoxSimpsons.Checked)
            {
                sb.Append("Desc 13% -- Familia Simpsons");
            }

            return sb.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Cliente.carritoCliente.Clear();
                this.Close();
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow db = dtgvCarrito.CurrentRow;
            DataGridViewCellCollection coleccionCeldasSelect = db.Cells;
            int i, stockNegocio;
            float total = float.Parse(Validaciones.SacarSignoPeso(lblTotal.Text.ToString()));

            int idProducto = int.Parse(coleccionCeldasSelect[0].Value.ToString());
            string nombre = coleccionCeldasSelect[1].Value.ToString();
            string tipo = coleccionCeldasSelect[2].Value.ToString();
            float precio = float.Parse(coleccionCeldasSelect[3].Value.ToString());
            int stock = int.Parse(coleccionCeldasSelect[4].Value.ToString());

            if (total > 0)
            {
                i = Negocio.EncontrarIndexEnLista(Cliente.carritoCliente, idProducto);
                if (i != -1)
                {
                    Cliente.carritoCliente.RemoveAt(i);
                    i = Negocio.EncontrarIndexEnLista(Negocio.listaProductos, idProducto);
                    stockNegocio = Negocio.listaProductos[i].Stock;
                    Negocio.listaProductos[i].Stock = stockNegocio + 1;
                    ActualizarDtgv(dtgvCarrito, Cliente.carritoCliente);
                    ActualizarDtgv(dtgvStock, Negocio.listaProductos);
                    lblTotal.Text = Validaciones.PonerSignoPeso((total - precio).ToString());
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto a eliminar,o falta calcular", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void FormCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer player = new SoundPlayer("./CajaRegistradora.wav");
            player.Play();

        }
    }
}

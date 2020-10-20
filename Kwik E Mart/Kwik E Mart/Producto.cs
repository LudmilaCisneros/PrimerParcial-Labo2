using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private int stock;
        private float precio;
        private ETipo tipo;

        public enum ETipo
        {
            bebida,
            comestibles,
            golosinas,
            varios
        };


        private Producto()
        {
            this.nombre = "";
            this.idProducto = -1;
            this.stock = -1;
            this.precio = -1;
        }
        public int IdProducto
        {
            get => this.idProducto;
        }
        public string Nombre
        {
            get => this.nombre;
        }
        public ETipo Tipo
        {
            get => this.tipo;
        }
        public float Precio
        {
            get => this.precio;
        }
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
  
        public Producto(int idProducto,string nombre, int stock, float precio) : this()
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
        }

        public Producto(int idProducto,string nombre, int stock, float precio, ETipo tipo) : this(idProducto,nombre, stock, precio)
        {
            this.tipo = tipo;
        }
        public Producto(int idProducto, string nombre, int stock, float precio, string tipo) : this(idProducto, nombre, stock, precio)
        {
            if (Enum.IsDefined(typeof(ETipo), tipo))
            {
                this.tipo = (ETipo) Enum.Parse(typeof(ETipo), tipo);
            }
        }
        
        public static int RestarStock(int stock)
        {
            return stock-1;
        }
        public static bool VerificarStock(int stock)
        {
            bool hayStock;

            if (stock <= 0)
            {
                hayStock = false;
            }
            else
            {
                hayStock = true;
            }
            return hayStock;
        }
        public string ImprimirProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("idProducto: {0}\n", this.IdProducto);
            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            sb.AppendFormat("cantidad: {0}\n", this.Stock);
            sb.AppendFormat("Tipo: {0}\n", this.Tipo);
            sb.AppendFormat("Precio: {0}\n", this.Precio);
            sb.AppendLine();

            return sb.ToString();
        }




    }


}
    

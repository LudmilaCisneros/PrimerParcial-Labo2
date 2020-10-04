using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Producto
    {
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
        //private int codigoProducto = 0;


        private Producto()
        {
            this.nombre = "";
            this.stock = -1;
            this.precio = -1;
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
            get => this.stock;
        }

        public Producto(string nombre, int stock, float precio):this()
        {
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
            //this.codigoProducto = codigoProducto++;
        }
    
        public Producto(string nombre, int stock, float precio, ETipo tipo) : this(nombre, stock, precio)
        {
            this.tipo = tipo;
        }
        
        
    }
}

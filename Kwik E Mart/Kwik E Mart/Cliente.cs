using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Cliente
    {
        public List<Producto> carritoCliente;
        public bool simpsons;
        public float total;
        //nombre


        public Cliente()
        {
            carritoCliente = new List<Producto>();
            simpsons = false;
            total = 0f;
        }
        public Cliente(bool esSimpsons, List<Producto> carritoCliente,float total) : this()
        {
            this.carritoCliente.AddRange(carritoCliente);
            this.simpsons = true;
            this.total = total;
        }
        public float Total
        {
            set { this.total = value; }
        }


        public float CalcularTotal()
        {
            float total = 0;
            for (int i = 0; i < carritoCliente.Count; i++)
            {
                total += carritoCliente[i].Precio;
            }
            return this.Total = total;
        }

    }
}

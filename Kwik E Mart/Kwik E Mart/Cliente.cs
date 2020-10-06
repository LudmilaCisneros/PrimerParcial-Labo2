using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Cliente
    {
        public static List<Producto> carritoCliente;
        public static bool simpsons = false;
        public static float total;
        

        static Cliente()
        {
            carritoCliente = new List<Producto>();
            total = 0f;
        }

        public static float CalcularTotal()
        {
            float total = 0;
            for (int i = 0; i < carritoCliente.Count; i++)
            {
                total += carritoCliente[i].Precio;
            }
            return total;
        }

    }
}

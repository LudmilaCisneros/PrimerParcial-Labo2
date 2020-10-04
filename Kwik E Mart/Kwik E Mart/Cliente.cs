using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Cliente : Persona
    {
        public static List<Producto> carritoCliente;
        private enum mediosDePago
        {
            tarjetaCredito = 0,
            tarjetaDebito = 1,
            efectivo = 2
        };
        mediosDePago medioDePago;
        

        public Cliente()
        {
            carritoCliente = new List<Producto>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public abstract class MedioDePago
    {
        protected string descripcion;

        public  MedioDePago()
        {
            this.descripcion = string.Empty;
        }

        /// <summary>
        /// Generar el medio de pago en el ticket de compra
        /// </summary>
        /// <returns></returns>
        public virtual string GenerarTicketMediodePago()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Medio de pago: ");

            return sb.ToString();
        }

    }
}

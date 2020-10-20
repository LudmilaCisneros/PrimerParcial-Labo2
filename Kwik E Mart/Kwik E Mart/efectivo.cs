using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class efectivo : MedioDePago
    {
        public efectivo() : base()
        {
            this.descripcion = "efectivo";
        }
        //public override void Pagar()
        //{
        //    this.descripcion = "efectivo";
        //}
        /// <summary>
        /// override del metodo Mostrar
        /// </summary>
        /// <returns></returns>
        public override string GenerarTicketMediodePago()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.GenerarTicketMediodePago());
            sb.AppendLine("efectivo");
            return sb.ToString();
        }
    }
}

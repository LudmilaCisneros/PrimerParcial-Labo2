using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class debito : MedioDePago
    {
        public debito() : base()
        {
            this.descripcion = "debito";
        }
        public override string GenerarTicketMediodePago()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.GenerarTicketMediodePago());
            sb.AppendLine("Tarjeta débito");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class credito : MedioDePago
    {
        public credito() : base()
        {
            this.descripcion = "credito";
        }

        public override string GenerarTicketMediodePago()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.GenerarTicketMediodePago());
            sb.AppendLine("Tarjeta crédito");
            return sb.ToString();
        }
    }
}

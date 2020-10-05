using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Empleado
    {
        //public Dictionary<string,string>
        private string usuario;
        private string password;

        public Empleado()
        {
            usuario = "";
            password = "";
        }

        public Empleado(string usuario, string password):this()
        {
            this.usuario = usuario;
            this.password = password;
        }




    }
}


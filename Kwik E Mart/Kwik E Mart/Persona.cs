using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = -1;
        }
        public Persona(string nombre, string apellido, int dni) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Validaciones
    {
        public static bool EsNumerico(string auxiliar)
        {
            bool respuesta = false;
            int auxInt;

            if (int.TryParse(auxiliar, out auxInt))
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static string AgregarMayuscula(string nombre)
        {
            if(EsNumerico(nombre))
            {
                return "No es un nombre";
            }
            else
            {
                nombre = nombre.Substring(0, 1).ToUpper() + nombre.Substring(1).ToLower();
            }
            return nombre;
        }
        /*
        public static ValidarSiEsVacioONull(string aux,string textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox))
            {
                MessageBox.Show("Debe ingresar un nombre","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        NOMBRE.TRIM elimina los espacios en blanco de un string
        }*/
    }
}

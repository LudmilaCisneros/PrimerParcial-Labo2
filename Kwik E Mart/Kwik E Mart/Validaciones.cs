using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Validaciones
    {
        /// <summary>
        /// Indica si es numerico el str.
        /// </summary>
        /// <param name="auxiliar"></param>
        /// <returns>bool true o false</returns>
        public static bool EsNumerico(string auxiliar)
        {
            bool respuesta = false;
            float auxInt;

            if (float.TryParse(auxiliar, out auxInt))
            {
                respuesta = true;
            }
            return respuesta;
        }

        /// <summary>
        /// Le agrega la mayuscula al string
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>string </returns>
        public static string AgregarMayuscula(string nombre)
        {
            if (EsNumerico(nombre) || string.IsNullOrEmpty(nombre))
            {
                return "No es un nombre";
            }
            else
            {
                nombre = nombre.Substring(0, 1).ToUpper() + nombre.Substring(1).ToLower();
            }
            return nombre;
        }

        public static string SacarSignoPeso(string precioStr)
        {
            precioStr = precioStr.Substring(1);
            return precioStr;
        }
        public static string PonerSignoPeso(string precioStr)
        {
            precioStr = precioStr.Insert(0, "$");

            return precioStr;
        }
        public static float Sacar13PorcAumento(float numero)
        {
            return numero / 0.87f;
        }


    }
        


    
}

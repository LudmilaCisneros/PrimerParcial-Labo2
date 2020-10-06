using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kwik_E_Mart
{
    public static class Negocio
    {
        public static List<Producto> listaProductos;
        public static Dictionary<string,string> usuariosPass;


        static Negocio()
        {
            listaProductos = new List<Producto>();
            usuariosPass = new Dictionary<string, string>();
            CargarUsuariosPasswords();
            //listaEmpleados = new List<Empleado>();
            CargarProductosDisponibles(listaProductos);
        }

        public static void CargarUsuariosPasswords()
        {
            usuariosPass.Add("Apu", "1234");
            usuariosPass.Add("Sanjay", "holi");
        }
        public static void CargarProductosDisponibles(List<Producto> listaProductos)
        {
            listaProductos.Add(new Producto(1, "cerveza Duff", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(2, "cigarrillos Laramie", 10, 150, Producto.ETipo.varios));
            listaProductos.Add(new Producto(3, "rosquilla", 40, 20, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(4, "hot dog", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(5, "waffles", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(6, "buzz Cola", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(7, "boletos loteria", 20, 15, Producto.ETipo.varios));
            listaProductos.Add(new Producto(8, "patatas fritas", 20, 30, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(9, "chupelupes", 20, 5.60f, Producto.ETipo.golosinas));
            listaProductos.Add(new Producto(10, "mani", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(11, "butterfinger", 20, 100, Producto.ETipo.golosinas));
            listaProductos.Add(new Producto(12, "tarta de luna", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(13, "leche", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(14, "anciano congelado", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(15, "telefono dulce", 20, 100, Producto.ETipo.golosinas));
            listaProductos.Add(new Producto(16, "revistas porno", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(17, "tarjetas", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(18, "jamon", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(19, "raspados", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(20, "armas", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(21, "preservativos", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(22, "radioctive man comics", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(23, "cereales Krusty", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(24, "pan de astronauta", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(25, "hamburguesa", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(26, "squishees", 20, 100, Producto.ETipo.golosinas));
            listaProductos.Add(new Producto(27, "horoscopos", 20, 100, Producto.ETipo.varios));
            listaProductos.Add(new Producto(28, "fruta", 20, 100, Producto.ETipo.comestibles));
            listaProductos.Add(new Producto(29, "café", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(30, "agua", 20, 100, Producto.ETipo.bebida));
            listaProductos.Add(new Producto(31, "prueba", 0, 100, Producto.ETipo.bebida));

            return;
        }
        public static int EncontrarIndexEnLista(List<Producto> listaProductos, int idProducto)
        {
            int index = -1;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].IdProducto == idProducto)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static string generarTextoUsuariosPass()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string,string> item in usuariosPass)
            {
                sb.AppendLine();
                sb.AppendFormat("{0}  -  {1}\n", item.Key,item.Value);
            }
            return sb.ToString();
        }

    }
}

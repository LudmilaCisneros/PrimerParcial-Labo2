using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Negocio
    {
        public static List<Producto> listaProductos;
        public static List<Empleado> listaEmpleados;
        //public static List<Producto> carritoCliente;


        static Negocio()
        {
            listaProductos = new List<Producto>();
            //listaEmpleados = new List<Empleado>();
            CargarProductosDisponibles(listaProductos);
        }
        public static void CargarProductosDisponibles(List<Producto> listaProductos)
        {
            listaProductos.Add(new Producto("cerveza Duff",20,100,Producto.ETipo.bebida));
            listaProductos.Add(new Producto("cigarrillos Laramie",10,150,Producto.ETipo.varios));
            listaProductos.Add(new Producto("rosquilla",40,20,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("hot dog",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("waffles",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("buzz Cola",20,100,Producto.ETipo.bebida));
            listaProductos.Add(new Producto("boletos loteria",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("patatas fritas",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("chupelupes",20,100,Producto.ETipo.golosinas));
            listaProductos.Add(new Producto("mani",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("butterfinger",20,100,Producto.ETipo.golosinas));
            listaProductos.Add(new Producto("tarta de luna",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("leche",20,100,Producto.ETipo.bebida));
            listaProductos.Add(new Producto("anciano congelado",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("telefono dulce",20,100,Producto.ETipo.golosinas));
            listaProductos.Add(new Producto("revistas porno",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("tarjetas",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("jamon",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("raspados",20,100,Producto.ETipo.bebida));
            listaProductos.Add(new Producto("armas",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("preservativos",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("radioctive man comics",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("cereales Krusty",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("pan de astronauta",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("hamburguesa",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("squishees", 20,100,Producto.ETipo.golosinas));
            listaProductos.Add(new Producto("horoscopos",20,100,Producto.ETipo.varios));
            listaProductos.Add(new Producto("fruta",20,100,Producto.ETipo.comestibles));
            listaProductos.Add(new Producto("café",20,100,Producto.ETipo.bebida));
            listaProductos.Add(new Producto("agua",20,100,Producto.ETipo.bebida));

            return;
        }
    }
}

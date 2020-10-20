using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Compra
    {
        private string nombreCliente;
        private string nombreVendedor;
        Cliente cliente;
        private MedioDePago medioPago;

        private Compra()
        {
            this.nombreCliente = "";
            this.nombreVendedor = "";
        }
        public Compra(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }
        public Compra(Cliente cliente,string nombreCte,string nombreVendedor,string formaDePago) : this(cliente)
        {
            this.nombreCliente = nombreCte;
            this.nombreVendedor = nombreVendedor;
            cualFormaDePago(formaDePago);
        }
        private void cualFormaDePago(string formaDePago)
        {
            switch(formaDePago)
            {
                case "efectivo":
                    this.medioPago = new efectivo();
                    break;

                case "debito":
                    this.medioPago = new debito();
                    break;

                case "credito":
                    this.medioPago = new credito();
                    break;

            }
        }
        public string NombreCliente
        {
            get { return this.nombreCliente; }
        }
        public string NombreVendedor
        {
            get { return this.nombreVendedor; }
        }
        public MedioDePago MediodePago
        {
            get { return this.medioPago; }
        }

        public static bool operator ==(List<Compra> listaAux, Compra compra)
        {
            bool existe=false;
            for (int i = 0; i < listaAux.Count; i++)
            {
                if(listaAux[i].Equals(compra))
                {
                    existe = true;
                    return existe;
                }
            }
            return existe;
        }
        public static bool operator !=(List<Compra> listaAux, Compra compra)
        {
            return !(listaAux == compra);
        }
        public static bool operator +(List<Compra> listaAux,Compra compra)
        {
            bool seSumo = true;

            for (int i = 0; i < listaAux.Count; i++)
            {
                if(listaAux[i] == compra)
                {
                    seSumo = false;
                    return seSumo;
                }
            }
            listaAux.Add(compra);

            return seSumo;
        }

        public static bool operator -(List<Compra> listaAux, Compra compra)
        {
            bool seResto = false;

            for (int i = 0; i < listaAux.Count; i++)
            {
                if (listaAux[i] == compra)
                {
                    listaAux.RemoveAt(i);
                    seResto = true;
                    return seResto;
                }
            }
            return seResto;
        }

    }
    
}

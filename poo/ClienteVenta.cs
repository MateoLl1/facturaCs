using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class ClienteVenta :Cliente
    {
        private int numeroVenta;
        private string direccion;
        private bool credito;
        private double precio;
        private DateTime fecha;


        public int NumeroVenta { get => numeroVenta; set => numeroVenta = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Credito { get => credito; set => credito = value; }
        
        public double Precio { get => precio; set => precio = value; }
    }
}

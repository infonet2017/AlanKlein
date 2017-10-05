using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Compra
    {
        private readonly object compras;

        public int numero { get; set; }
        public string clienteNombre { get; set; }
        public double precioTotal { get; set; }
        public List<Producto> compraTot { get; set; }


       

        public void NuevaCompra(Producto prod, string cliente)
        {

            if (this.compraTot.Count == 0)
            {
                this.precioTotal = 0;
            }

            this.numero = this.numero + 1;
            this.clienteNombre = cliente;
            this.compraTot.Add(prod);
            this.precioTotal = this.precioTotal + prod.precioUnit;

        }

        


    }
}

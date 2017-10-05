using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Producto
    {
        public string nombreProd { get; set; }
        public int codigo { get; set; }
        public double precioUnit { get; set; }
        public int stock { get; set; }



        public Producto (string nombre, int codigo,double precio)
        {
            this.nombreProd = nombre;
            this.codigo = codigo;
            this.precioUnit = precio;
        }

        public void CargarStockInicial(int stock)
        {
            this.stock = stock;
        }

        public void RestarStock (int stock)
        {
            if (this.stock < stock)
            {
                throw new Exception("No hay suficiente stock");
            }
            else
            {
                //otherwise it stores the pokemon successfully
                this.stock = this.stock - stock;
            }
        }

        public void AgregarStock(int stock)
        {
            this.stock = this.stock + stock;
        }
    }
}

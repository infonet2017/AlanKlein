using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Transaccion
    {
        public int numeroTrans { get; set; }
        public int tipo { get; set; }
        public double monto { get; set; }
        /*public Producto product { get; set; }*/

        public Transaccion(int numeroT, int tipo, double monto) 
        {
            this.numeroTrans = numeroT;
            this.tipo = tipo;
            this.monto = monto;
            
        }
        
    }
}

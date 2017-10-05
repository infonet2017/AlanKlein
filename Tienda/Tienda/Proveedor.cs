using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Proveedor
    {
        internal string nombreProv { get; set; }
        internal string rubro { get; set; }
        internal double deuda { get; set; }
        internal double prestado { get; set; }
        internal Transaccion trans { get; set; }


        public Proveedor(string name, string rubro, double deuda, double prestado)
        {
            this.nombreProv = name;
            this.rubro = rubro;
            this.deuda = deuda;
            this.prestado = prestado;
        }

        public double PagarDeuda(double monto)
        {
            double vuelto;
            if (this.deuda >= monto)
            {
                vuelto = 0;
                this.deuda = this.deuda - monto;
            }
            else
            {
                vuelto = monto - this.deuda;
                this.deuda = 0;
            }

            return vuelto;
        }

        public double CobrarPrestamo (double monto)
        {
            double vuelto;
            if (this.prestado <= monto)
            {
                vuelto = 0;
                this.prestado = this.prestado - monto;
            }
            else
            {
                vuelto = monto - this.prestado;
                this.prestado = 0;
            }

            return vuelto;
        }
    }
}

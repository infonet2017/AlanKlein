using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Caja
    {
        public double saldoDisp { get; set; }
        public double totalPorCobrar { get; set; }
        public double deudaTot { get; set; }

        public Caja(double saldo, double porcob, double deuda)
        {
            this.deudaTot = deuda;
            this.totalPorCobrar = porcob;
            this.saldoDisp = saldo;
        }

        public void SumarSaldo(double saldo)
        {
            this.saldoDisp = this.saldoDisp + saldo;
        }

        public void RestarSaldo(double saldo)
        {
            if (this.saldoDisp < saldo)
            {
                throw new Exception("no hay saldo suficiente");
            }
            else
            {
                this.saldoDisp = this.saldoDisp - saldo;
            }
        }

        public double DescontarDeuda(double monto)
        {
            double vuelto;
            if (this.deudaTot < monto)
            {
                vuelto = monto - this.deudaTot;
            }
            else
            {
                vuelto = 0;
                this.deudaTot = this.deudaTot - monto;
            }
            return vuelto;
        }
        public double Cobrar(double monto)
        {
            double vuelto;
            if (this.totalPorCobrar < monto)
            {
                vuelto = monto - this.totalPorCobrar;
            }
            else
            {
                vuelto = 0;
                this.totalPorCobrar = this.totalPorCobrar - monto;
            }
            return vuelto;
        }
    }
}

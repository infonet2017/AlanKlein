using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            Caja miCaja = new Caja(10000, 0, 0);

            Console.WriteLine("Saldo: " + miCaja.saldoDisp + " Deuda: " + miCaja.deudaTot + "Prestamos: " + miCaja.totalPorCobrar);
            Console.ReadLine();

            Proveedor miProveedor = new Proveedor("prove1", "mesas", 1200, 0);
            storage.AgregarProveedor(miProveedor);
            miCaja.deudaTot = miCaja.deudaTot + miProveedor.prestado;
            miCaja.totalPorCobrar = miCaja.totalPorCobrar + miProveedor.deuda;
            miProveedor = new Proveedor("prove2", "sillas", 200, 1500);
            storage.AgregarProveedor(miProveedor);
            miCaja.deudaTot = miCaja.deudaTot + miProveedor.prestado;
            miCaja.totalPorCobrar = miCaja.totalPorCobrar + miProveedor.deuda;
            miProveedor = new Proveedor("prove3", "sillas", 200, 150);
            storage.AgregarProveedor(miProveedor);
            miCaja.deudaTot = miCaja.deudaTot + miProveedor.prestado;
            miCaja.totalPorCobrar = miCaja.totalPorCobrar + miProveedor.deuda;

            int pos = storage.GetPos("mesa");
            Console.WriteLine(storage.proveedores[pos+1].deuda);
            Console.ReadLine();


            Producto miProducto = new Producto("mesa", 1, 330.20);
            storage.AgregarProducto(miProducto);
            miProducto = new Producto("silla",2, 500);
            storage.AgregarProducto(miProducto);
            miProducto = new Producto("panchin", 1, 220.20);
            storage.AgregarProducto(miProducto);

            Console.WriteLine("Bienvenido, seleccione lo que quiera hacer: \n 1- Realizar una compra \n 2- Agregar un nuevo Producto \n" +
                " 3- Pagar una deuda a un proveedor \n 4-Cobrar un prestamo a un proveedor \n 5-Proveerse de un producto");
            int.TryParse(Console.ReadLine(), out int opcion);

            switch (opcion)
            {
                case 1:
                    Compra miCompra = new Compra();
                    miCompra.NuevaCompra(storage.GetProducto(2), "pepegrillo"); /* aca puede ir un buclesiño*/

                    storage.AgregarCompra(miCompra);
                    miCaja.SumarSaldo(miCompra.precioTotal);
                    Console.WriteLine("Saldo: " + miCaja.saldoDisp + " Deuda: " + miCaja.deudaTot + "Prestamos: " + miCaja.totalPorCobrar);
                    Console.ReadLine();
                    break;

                case 2:
                    miProducto = new Producto("panchin", 1, 220.20);/* arriba iria una peticion de los datos*/
                    storage.AgregarProducto(miProducto);
                    break;
                case 3:
                    pos = storage.GetPos("silla");
                    storage.proveedores[pos + 1].CobrarPrestamo(1000);
                    miCaja.RestarSaldo(1000);
                    miCaja.deudaTot = miCaja.deudaTot - 1000;
                    Console.WriteLine(storage.proveedores[pos + 1].prestado);
                    Console.ReadLine();
                    break;

                case 4:
                    /* pide a quien le quiere cobre, despues pediria el monto a pagar*/
                    pos = storage.GetPos("mesa");
                    storage.proveedores[pos+1].PagarDeuda(1000);
                    Console.WriteLine(storage.proveedores[pos+1].deuda);
                    Console.ReadLine();
                    break;

                case 5:
                    
                default:
                    break;
            }



        }
    }
}

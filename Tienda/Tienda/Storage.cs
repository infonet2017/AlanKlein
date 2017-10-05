using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Storage
    {
        public List<Producto> inventario { get; set; }
        public List<Compra> compras { get; set; }
        public List<Proveedor> proveedores { get; set; }

        public Storage()
        {
            inventario = new List<Producto>();
            compras = new List<Compra>();
            proveedores = new List<Proveedor>();
        }

        public void AgregarProducto(Producto prod)
        {
            inventario.Add(prod);
        }

        public void EliminarProducto(int codigo)
        {
            inventario.RemoveAll(p => p.codigo == codigo);
        }

        public Producto GetProducto(int codigo)
        {
            return inventario.Find(p => p.codigo == codigo);
        }

        public void AgregarCompra(Compra comp)
        {
            compras.Add(comp);
        }

        

        public void AgregarProveedor(Proveedor prov)
        {
            proveedores.Add(prov);
        }

        public void EliminarProveedor(string nombre)
        {
            proveedores.RemoveAll(p => p.nombreProv == nombre);
        }

        public Proveedor GetProveedor(string name)
        {
            return proveedores.Find(p => p.nombreProv == name);
        }
        public int GetPos(string name)
        {
            return proveedores.FindLastIndex(p => p.nombreProv == name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;//Librería que nos permitirá hacer una lista de prodcutos //**
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }//**

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            //DATOS DE PRUEBA, MIENTRAS NO ESTA LA BASE DE DATOS

            var Producto1 = new Producto();
            Producto1.Id = 1;
            Producto1.Descripcion = "iPhoneX";
            Producto1.Precio = 25000;
            Producto1.Existencia = 15;
            Producto1.Activo = true;

            ListaProductos.Add(Producto1);

            var Producto2 = new Producto();
            Producto2.Id = 2;
            Producto2.Descripcion = "SAMSUNG S5";
            Producto2.Precio = 14200;
            Producto2.Existencia = 7;
            Producto2.Activo = true;

            ListaProductos.Add(Producto2);

            var Producto3 = new Producto();
            Producto3.Id = 3;
            Producto3.Descripcion = "PC HP";
            Producto3.Precio = 32000;
            Producto3.Existencia = 3;
            Producto3.Activo = true;

            ListaProductos.Add(Producto3);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public bool GuardarProducto(Producto Producto)
        {
            if(Producto.Id == 0)
            {
                Producto.Id = ListaProductos.Max(item => item.Id) + 1;//Funcion Max que busca en toda la lista
            }
            return true;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }

            return false;
        }
    }

    public class Producto //CLASE
    {
        public int Id { get; set; } //Propiedad
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}

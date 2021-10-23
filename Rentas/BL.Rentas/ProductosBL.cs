using System;
using System.Collections.Generic;
using System.ComponentModel;//Librería que nos permitirá hacer una lista de prodcutos //**
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProductosBL
    {
        Contexto _contexto;

        public BindingList<Producto> ListaProductos { get; set; }//**

        public ProductosBL()
        {
            _contexto = new Contexto(); // Instanciamos la variable _contexto.
            ListaProductos = new BindingList<Producto>();          
        }//

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }//

        public Resultado GuardarProducto(Producto Producto)
        {
            var resultado = Validar(Producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if(Producto.Id == 0)
            {
                Producto.Id = ListaProductos.Max(item => item.Id) + 1;//Funcion Max que busca en toda la lista
            }
            resultado.Exitoso = true;
            return resultado;
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

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "La precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;
        }//Resultado Validar.

    } // Fin class ProductosBL.

    public class Producto //CLASE
    {
        public int Id { get; set; } //Propiedad
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

}

using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormProductos : Form
    {
        ProductosBL _Productos;

        public FormProductos()
        {
            InitializeComponent();

            _Productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _Productos.ObtenerProductos();
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();//Le dice que termine de editar.
            var Producto = (Producto)listaProductosBindingSource.Current;

            var Resultado = _Productos.GuardarProducto(Producto);
            if(Resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar el Producto");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);
            var resultado = _Productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Producto");
            }
        }
    }
}

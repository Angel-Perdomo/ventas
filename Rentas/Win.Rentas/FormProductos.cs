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

            if(Resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabililarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(Resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabililarHabilitarBotones(false);
        }

        private void DeshabililarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1Cancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {          
            if (idTextBox.Text != "")
            {
               var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
               if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
               
            }
            

            
        }

        private void Eliminar(int id)
        {
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

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            DeshabililarHabilitarBotones(true);
            Eliminar(0); //Eliminar Id cero
        }
    }
}

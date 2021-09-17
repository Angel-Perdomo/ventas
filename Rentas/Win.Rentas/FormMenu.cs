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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login(); //Método login.
        }

        private void login() //Función login.
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormClientes = new FormClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
        }

        private void rentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormRentas = new FormRentas();
            FormRentas.MdiParent = this;
            FormRentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}

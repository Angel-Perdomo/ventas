using BL.Rentas; // Librería Rentas
using System;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormLogin : Form
    {
        SeguridadBL _Seguridad; // Variable gobal

        public FormLogin()
        {
            InitializeComponent();

            _Seguridad = new SeguridadBL();
        }

        private void button2cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1aceptar_Click(object sender, EventArgs e)
        {   
            string usuario;
            string contrasenia;

            //Asignamos los valores de los TextBox.
            usuario = textBox1user.Text; 
            contrasenia = textBox2pass.Text;

            var resultado = _Seguridad.Autorizar(usuario, contrasenia);

            if(resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta!");
            }

        } // Fin button1aceptar_Click
    }
}

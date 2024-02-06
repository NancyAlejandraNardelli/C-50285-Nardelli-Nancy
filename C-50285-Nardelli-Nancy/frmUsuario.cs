using C_50285_Nardelli_Nancy.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_50285_Nardelli_Nancy
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public Usuario UsuarioCreado { get; private set; }
     
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo usuario con los datos ingresados
            Usuario usuario = new Usuario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreUsuario = txtUsuario.Text,
                Contraseña = txtPassword.Text,
                Mail = txtEmail.Text
            };
            // Asignar el usuario creado a la propiedad UsuarioCreado
            UsuarioCreado = usuario;

            // Cerrar el formulario
            this.Close();

        }
    }

}


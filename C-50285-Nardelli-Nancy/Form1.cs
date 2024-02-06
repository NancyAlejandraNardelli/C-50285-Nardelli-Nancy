using C_50285_Nardelli_Nancy.models;
using C_50285_Nardelli_Nancy.service;
using System;

namespace C_50285_Nardelli_Nancy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnListar_Click(object sender, EventArgs e)
        //{
        //    List<Usuario> usuarios = UsuarioService.getAllUsers();
        //    //this.dgvUser.DataSource = usuarios;
        //    ActualizarDgv(usuarios);
        //}
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && int.TryParse(txtId.Text, out int userId))
            {
                // Si txtId tiene valor y es un número, buscar por ID
                Usuario usuario = UsuarioService.GetUserById(userId);
                if (usuario != null)
                {
                    // Cargar el usuario en una lista para mostrarlo en la grilla
                    List<Usuario> usuarios = new List<Usuario> { usuario };
                    ActualizarDgv(usuarios);
                }
                else
                {
                    // Mostrar mensaje indicando que no se encontró un usuario con ese ID
                    MessageBox.Show("No se encontró un usuario con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si txtId está vacío listar todos los usuarios
                List<Usuario> usuarios = UsuarioService.GetAllUsers();
                ActualizarDgv(usuarios);
            }
        }

        private void ActualizarDgv(object objeto)
        {
            this.dgvUser.DataSource = null;
            this.dgvUser.DataSource = objeto;


        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //frmUsuario frmAlta = new frmUsuario();
            //frmAlta.ShowDialog();
            //this.Hide();

            //Usuario usuario = frmAlta.UsuarioCreado;
            //if (UsuarioService.AddUser(usuario))
            //{
            //    MessageBox.Show(text: "Agregue un usuario", caption: "Alta"); ;
            //}
            //this.Show();
            frmUsuario frmAlta = new frmUsuario();
            frmAlta.ShowDialog();
            this.Hide();

            Usuario usuario = frmAlta.UsuarioCreado;

            if (UsuarioService.AddUser(usuario))
            {
                MessageBox.Show("Usuario agregado exitosamente", "Alta");

                // Listar nuevamente los usuarios y actualizar la grilla
                List<Usuario> usuarios = UsuarioService.GetAllUsers();
                ActualizarDgv(usuarios);
            }

            this.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en la grilla
            if (dgvUser.SelectedRows.Count > 0)
            {
                // Obtener el ID de la fila seleccionada
                int idUsuario = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["Id"].Value);

                // Intentar eliminar el usuario
                if (UsuarioService.DeleteUser(idUsuario))
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Eliminar Usuario");
                    List<Usuario> usuarios = UsuarioService.GetAllUsers();
                    ActualizarDgv(usuarios);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el usuario para eliminar.", "Eliminar Usuario");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Eliminar Usuario");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
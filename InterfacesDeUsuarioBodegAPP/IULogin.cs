using GestionDeBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios.Peticiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesDeUsuarioBodegAPP
{
    public partial class IULogin : Form
    {
        public IULogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IGestorDeUsuario gestorDeUsuarios = new GestorDeUsuario();
            if (gestorDeUsuarios.ValidarUsuario(txtUsuario.Text, txtContrasena.Text) == true)
            {
                lblMensajeError.Visible = false;
                MessageBox.Show("Bienvenido al Sistema BodegAPP");
            }
            else
            {
                lblMensajeError.Text = "Datos Incorrectos";
                lblMensajeError.Visible = true;
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtUsuario.Focus();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(this, new EventArgs());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

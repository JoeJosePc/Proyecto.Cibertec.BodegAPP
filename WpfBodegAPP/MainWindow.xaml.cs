using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfBodegAPP.ViewModels;

namespace WpfBodegAPP
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IniciarSesionVM iniciarSesionVM = new IniciarSesionVM();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsuario.Focus();
            txtUsuario.SelectAll();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            this.iniciarSesionVM.validarUsuario(this.txtUsuario.Text, this.txtContrasena.Password);

            if (this.iniciarSesionVM.usuarioValidado == true)
            {
                MessageBox.Show("Bienvenido al Sistema BodegAPP v0.1");
            }
            else
            {
                this.lblMensajeError.Visibility = Visibility.Visible;
                this.txtUsuario.Text = "";
                this.txtContrasena.Password = "";
                this.txtUsuario.Focus();
                this.txtUsuario.SelectAll();
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnIngresar_Click(this, new RoutedEventArgs());
            }
        }
    }
}

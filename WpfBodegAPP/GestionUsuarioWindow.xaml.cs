using InterfacesBodegAPP.Usuarios.Respuestas;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using WpfBodegAPP.ViewModels;

namespace WpfBodegAPP
{
    /// <summary>
    /// Lógica de interacción para GestionUsuarioWindow.xaml
    /// </summary>
    public partial class GestionUsuarioWindow : Window
    {
        private GestionDeUsuariosVM gestionDeUsuariosVM = new GestionDeUsuariosVM();
        public GestionUsuarioWindow()
        {
            InitializeComponent();
            CargarComboNivel();
            CargarComboEstado();
            gestionDeUsuariosVM.CargarUsuarios();
            this.DataContext = gestionDeUsuariosVM;
        }

        //Inicializamos los Combos
        private void CargarComboNivel()
        {
            this.cmbNivel.SelectedIndex = 0;
            List<GestionDeUsuariosVM> listaNiveles = new List<GestionDeUsuariosVM>();
            listaNiveles.Add(new GestionDeUsuariosVM { idNivel = 0, descripcionNivel = "Operador" });
            listaNiveles.Add(new GestionDeUsuariosVM { idNivel = 1, descripcionNivel = "Administrador" });

            this.cmbNivel.DisplayMemberPath = "descripcionNivel";
            this.cmbNivel.SelectedValuePath = "idNivel";
            this.cmbNivel.ItemsSource = listaNiveles;
        }
        private void CargarComboEstado()
        {
            this.cmbEstado.SelectedIndex = 0;
            List<GestionDeUsuariosVM> listaEstados = new List<GestionDeUsuariosVM>();
            listaEstados.Add(new GestionDeUsuariosVM { idEstado = 1, descripcionEstado = "Activo" });
            listaEstados.Add(new GestionDeUsuariosVM { idEstado = 0, descripcionEstado = "Dar Baja" });

            this.cmbEstado.DisplayMemberPath = "descripcionEstado";
            this.cmbEstado.SelectedValuePath = "idEstado";
            this.cmbEstado.ItemsSource = listaEstados;
        }
        //Cargar Paneles
        private void CargarPanelNuevoUsuario()
        {
            this.panelBotones.Visibility = Visibility.Collapsed;
            this.panelDatosUsuario.Visibility = Visibility.Visible;
            this.panelBotonNuevoUsuario.Visibility = Visibility.Visible;
            this.panelBotonActualizarUsuario.Visibility = Visibility.Collapsed;
            this.dgListadoUsuarios.IsEnabled = false;
            this.cmbEstado.IsEnabled = false;
            this.txtUsuario.IsEnabled = true;

            this.txtUsuario.Text = "";
            this.txtUsuario.Focus();
            this.txtUsuario.SelectAll();
            this.txtContrasena.Text = "";
            this.txtResponsable.Text = "";
        }
        private void CargarPanelInicial()
        {
            this.panelDatosUsuario.Visibility = Visibility.Collapsed;
            this.panelBotones.Visibility = Visibility.Visible;
            this.dgListadoUsuarios.IsEnabled = true;
        }
        private void CargarPanelActualizarUsuario()
        {
            this.panelBotones.Visibility = Visibility.Collapsed;
            this.panelDatosUsuario.Visibility = Visibility.Visible;
            this.panelBotonNuevoUsuario.Visibility = Visibility.Collapsed;
            this.panelBotonActualizarUsuario.Visibility = Visibility.Visible;
            this.dgListadoUsuarios.IsEnabled = true;
            this.cmbEstado.IsEnabled = true;

            this.txtUsuario.IsEnabled = false;
        }

        //Funcionalidad de Panel de Botones
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            CargarPanelActualizarUsuario();
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            CargarPanelNuevoUsuario();
        }

        //Funcionalidad de Botones Panel Datos de Usuario
        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtUsuario.Text == "" || this.txtContrasena.Text == "")
            {
                MessageBox.Show("USUARIO O CONTRASEÑA NO DEBEN SER VACIOS", "CAMPOS VACIOS");
            }
            else
            {
                if (gestionDeUsuariosVM.ExisteUsuario() == false)
                {
                    this.gestionDeUsuariosVM.nuevoUsuario.Nivel = this.cmbNivel.Text;
                    this.gestionDeUsuariosVM.AgregarUsuario();
                    CargarPanelInicial();
                }
            }
        }
        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            CargarPanelInicial();
        }

        //Seleccionar DataGrid para pasar los datos a los TextBox del Panel De Datos de Usuario
        private void DatosUsuarioRegistrado(UsuarioRegistrado usuarioRegistrado)
        {
            this.txtUsuario.Text = usuarioRegistrado.Usuario;
            this.txtContrasena.Text = usuarioRegistrado.Contrasena;
            this.txtResponsable.Text = usuarioRegistrado.Responsable;
            this.cmbNivel.Text = usuarioRegistrado.Nivel;
            this.cmbEstado.SelectedValue = Convert.ToInt32(usuarioRegistrado.Estado); 
        }
        private void dgListadoUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgListadoUsuarios.SelectedIndex != -1)
            {
                UsuarioRegistrado usuarioRegistrado = this.dgListadoUsuarios.SelectedItem as UsuarioRegistrado;
                DatosUsuarioRegistrado(usuarioRegistrado);
            }
        }

        private void btnActualizarUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.gestionDeUsuariosVM.usuarioActualizado.Usuario = this.txtUsuario.Text;
            this.gestionDeUsuariosVM.usuarioActualizado.Contrasena = this.txtContrasena.Text;
            this.gestionDeUsuariosVM.usuarioActualizado.Responsable = this.txtResponsable.Text;
            this.gestionDeUsuariosVM.usuarioActualizado.Nivel = this.cmbNivel.Text;
            this.gestionDeUsuariosVM.usuarioActualizado.Estado = Convert.ToString(this.cmbEstado.SelectedValue);
            this.gestionDeUsuariosVM.ActualizarDatosDeUsuario();
            this.dgListadoUsuarios.ItemsSource = null;
            this.dgListadoUsuarios.ItemsSource = gestionDeUsuariosVM.usuariosResgistrados;
            CargarPanelInicial();
        }
    }
}

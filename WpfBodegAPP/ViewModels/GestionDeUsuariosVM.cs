using GestionDeBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios.Peticiones;
using InterfacesBodegAPP.Usuarios.Respuestas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfBodegAPP.ViewModels
{
    public class GestionDeUsuariosVM:BaseEntity
    {
        public ObservableCollection<UsuarioRegistrado> usuariosResgistrados { get; set; }
        private IGestorDeUsuario _gestionDeUsuarios = new GestorDeUsuario();

        public void CargarUsuarios()
        {
            var usuarios = _gestionDeUsuarios.ListarTodosLosUsuarios();
            this.usuariosResgistrados = new ObservableCollection<UsuarioRegistrado>(usuarios);
        }

        //cmbNivel para seleccionar el Rol Funcional
        private int _idNivel;
        public int idNivel
        {
            get { return _idNivel; }
            set { _idNivel = value; }
        }

        private string _descripcionNivel;
        public string descripcionNivel
        {
            get { return _descripcionNivel; }
            set { _descripcionNivel = value; }
        }

        //cmbEstadi para seleccionar el Estado
        private int _idEstado;
        public int idEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        private string _descripcionEstado;
        public string descripcionEstado
        {
            get { return _descripcionEstado; }
            set { _descripcionEstado = value; }
        }

        //controlador para el uso de la interfaz nuevoUsuario
        private NuevoUsuario _nuevoUsuario = new NuevoUsuario();
        public NuevoUsuario nuevoUsuario
        {
            get { return _nuevoUsuario; }
            set
            {
                this._nuevoUsuario = value;
                this.OnPropertyChanged("nuevoUsuario");
            }
        }

        public void AgregarUsuario()
        {
            UsuarioRegistrado nuevoUsuarioRegistrado = this._gestionDeUsuarios.CrearUsuario(this.nuevoUsuario);
            this.usuariosResgistrados.Add(nuevoUsuarioRegistrado);
            this.nuevoUsuario = new NuevoUsuario();
        }

        public bool ExisteUsuario()
        {
            if(this._gestionDeUsuarios.ExisteUsuario(this.nuevoUsuario.Usuario) == true)
            {
                MessageBox.Show("EL USUARIO YA EXISTE, PRUEBE OTRO POR FAVOR","Existe Usuario");
                return true;
            }
            else
            {
                return false;
            }
        }

        //controlador para la actualizacion de Usuario
        private UsuarioActualizado _usuarioActualizado = new UsuarioActualizado();
        public UsuarioActualizado usuarioActualizado
        {
            get { return _usuarioActualizado; }
            set
            {
                this._usuarioActualizado = value;
                this.OnPropertyChanged("usuarioActualizado");
            }
        }
        public void ActualizarDatosDeUsuario()
        {
            UsuarioRegistrado actualizarUsuarioRegistrado = this._gestionDeUsuarios.ActualizarUsuario(this.usuarioActualizado);
            CargarUsuarios();
        }
    }
}

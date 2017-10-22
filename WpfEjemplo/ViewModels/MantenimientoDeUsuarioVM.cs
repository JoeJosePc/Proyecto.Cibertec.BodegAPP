using GestionDeBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios.Peticiones;
using InterfacesBodegAPP.Usuarios.Respuestas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEjemplo.ViewModels
{
    public class MantenimientoDeUsuarioVM:BaseEntity
    {
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
            UsuarioRegistrado nuevoUsuarioRegistrado = this._gestorDeUsuarios.CrearUsuario(this.nuevoUsuario);
            this.usuariosResgistrados.Add(nuevoUsuarioRegistrado);
            this.nuevoUsuario = new NuevoUsuario();
        }

        public ObservableCollection<UsuarioRegistrado> usuariosResgistrados { get; set; }
        private IGestorDeUsuario _gestorDeUsuarios = new GestorDeUsuario();

        public void CargarUsuarios()
        {
            var usuarios = _gestorDeUsuarios.ListarTodosLosUsuarios();
            this.usuariosResgistrados = new ObservableCollection<UsuarioRegistrado>(usuarios);
        }
    }
}

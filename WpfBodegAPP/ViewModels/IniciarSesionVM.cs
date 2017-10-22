using GestionDeBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBodegAPP.ViewModels
{
    public class IniciarSesionVM:BaseEntity
    {
        public bool usuarioValidado { get; set; }
        private IGestorDeUsuario _gestorDeUsuario = new GestorDeUsuario();
        public void validarUsuario(string Usuario, string Contrasena)
        {
            bool usuarioValido = _gestorDeUsuario.ValidarUsuario(Usuario, Contrasena);
            usuarioValidado = usuarioValido;
        }
    }
}

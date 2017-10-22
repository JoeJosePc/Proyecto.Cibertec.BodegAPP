using InterfacesBodegAPP.Usuarios.Peticiones;
using InterfacesBodegAPP.Usuarios.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBodegAPP.Usuarios
{
    public interface IGestorDeUsuario
    {
        UsuarioRegistrado CrearUsuario(NuevoUsuario nuevoUsuario);
        List<UsuarioRegistrado> ListarTodosLosUsuarios();
        UsuarioRegistrado ActualizarUsuario(UsuarioActualizado usuarioActualizado);
        bool ValidarUsuario(string Usuario, string Contrasena);
        bool ExisteUsuario(string Usuario);
    }
}

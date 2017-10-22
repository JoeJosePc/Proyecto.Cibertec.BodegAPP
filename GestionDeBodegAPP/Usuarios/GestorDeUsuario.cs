using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios.Peticiones;
using InterfacesBodegAPP.Usuarios.Respuestas;
using Repositorio.AccesoDatosBodega.Contextos;
using Repositorio.AccesoDatosBodega.Modelos;
using System.Windows;

namespace GestionDeBodegAPP.Usuarios
{
    public class GestorDeUsuario : IGestorDeUsuario
    {
        public UsuarioRegistrado ActualizarUsuario(UsuarioActualizado usuarioActualizado)
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                Usuario_ usuario = bd.Usuario.Find(usuarioActualizado.Usuario);
                usuario.Contrasena = usuarioActualizado.Contrasena;
                usuario.Responsable = usuarioActualizado.Responsable;
                usuario.Nivel = usuarioActualizado.Nivel;
                usuario.Estado = Convert.ToBoolean(Convert.ToInt32(usuarioActualizado.Estado));
                bd.Entry(usuario);
                bd.SaveChanges();
                return ConvertirUsuarioA_DTO(usuario);
            }
        }

        public UsuarioRegistrado CrearUsuario(NuevoUsuario nuevoUsuario)
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                Usuario_ usuario = new Usuario_();
                usuario.Usuario = nuevoUsuario.Usuario;
                usuario.Contrasena = nuevoUsuario.Contrasena;
                usuario.Responsable = nuevoUsuario.Responsable;
                usuario.Nivel = nuevoUsuario.Nivel;
                bd.Usuario.Add(usuario);
                bd.SaveChanges();
                return ConvertirUsuarioA_DTO(usuario);
            }
        }

        public bool ExisteUsuario(string Usuario)
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                Usuario_ usuario = bd.Usuario.Find(Usuario);
                if(usuario == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public List<UsuarioRegistrado> ListarTodosLosUsuarios()
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                return bd.Usuario.ToList().Select(x => ConvertirUsuarioA_DTO(x)).ToList();
            }
        }

        public bool ValidarUsuario(string Usuario, string Contrasena)
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                try
                {
                    Usuario_ usuario = bd.Usuario.Find(Usuario);
                    if (usuario.Contrasena == Contrasena && usuario.Estado == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }

        private UsuarioRegistrado ConvertirUsuarioA_DTO(Usuario_ usuario)
        {
            UsuarioRegistrado usuarioRegistrado = new UsuarioRegistrado();
            usuarioRegistrado.Usuario = usuario.Usuario;
            usuarioRegistrado.Contrasena = usuario.Contrasena;
            usuarioRegistrado.Responsable = usuario.Responsable;
            usuarioRegistrado.Nivel = usuario.Nivel;
            usuarioRegistrado.Estado = usuario.Estado;
            return usuarioRegistrado;
        }
    }
}

using GestionDeBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios;
using InterfacesBodegAPP.Usuarios.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IGestorDeClientes gestorDeClientes = new GestorDeClientes();
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.Nombre = "Joe José";
            nuevoCliente.Apellido = "Pinedo Cortez";
            var fechaDeNacimiento = new DateTime(1989,9,6);

            nuevoCliente.FechaNacimiento = fechaDeNacimiento;
            nuevoCliente.Dni = "45937816";
            gestorDeClientes.CrearCliente(nuevoCliente);
            */


            /*
            IGestorDeClientes gestorDeClientes = new GestorDeClientes();
            ClienteActualizado clienteActualizado = new ClienteActualizado();
            clienteActualizado.Id = 1;
            clienteActualizado.telefono = "987005947";
            clienteActualizado.email = "joepinedocortez@gmail.com";
            gestorDeClientes.ActualizarCliente(clienteActualizado);
            */

            /*
            IGestorDeClientes gestorDeClientes = new GestorDeClientes();
            gestorDeClientes.BorrarCliente(1);
            */

            IGestorDeUsuario gestorDeUsuarios = new GestorDeUsuario();
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Usuario = "admin";
            nuevoUsuario.Contrasena = "123456";
            nuevoUsuario.Responsable = "Nathaly Karen Coico Timana";
            nuevoUsuario.Nivel = "administrador";
            gestorDeUsuarios.CrearUsuario(nuevoUsuario);

        }
    }
}

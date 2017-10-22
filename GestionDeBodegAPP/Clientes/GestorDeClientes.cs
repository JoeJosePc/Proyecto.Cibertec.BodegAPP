using InterfacesBodegAPP.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesBodegAPP.Clientes.Peticiones;
using InterfacesBodegAPP.Clientes.Respuestas;
using Repositorio.AccesoDatosBodega.Contextos;
using Repositorio.AccesoDatosBodega.Modelos;

namespace GestionDeBodegAPP.Clientes
{
    public class GestorDeClientes : IGestorDeClientes
    {
        public ClienteRegistrado ActualizarCliente(ClienteActualizado clienteActualizado)
        {
            using (BodegaContextos bd = new BodegaContextos())
            {
                Cliente_ cliente = bd.Cliente.Find(clienteActualizado.Id);
                cliente.Id = clienteActualizado.Id;
                cliente.telefono = clienteActualizado.telefono;
                cliente.email = clienteActualizado.email;
                cliente.FechaDeUltimaModificacion = DateTime.Now;
                bd.Entry(cliente);
                bd.SaveChanges();
                return ConvertirClienteA_DTO(cliente);
            }
        }

        public bool BorrarCliente(int ClienteID)
        {
            using(BodegaContextos bd = new BodegaContextos())
            {
                Cliente_ cliente = bd.Cliente.Find(ClienteID);
                cliente.Id = ClienteID;
                cliente.Estado = false;
                cliente.FechaDeUltimaModificacion = DateTime.Now;
                bd.Entry(cliente);
                bd.SaveChanges();
                return true;
            }
        }

        public ClienteRegistrado CrearCliente(NuevoCliente nuevoCliente)
        {
            using(BodegaContextos bd = new BodegaContextos())
            {
                Cliente_ cliente = new Cliente_();
                cliente.Nombre = nuevoCliente.Nombre;
                cliente.Apellido = nuevoCliente.Apellido;
                cliente.FechaNacimiento = nuevoCliente.FechaNacimiento;
                cliente.Dni = nuevoCliente.Dni;
                cliente.telefono = nuevoCliente.telefono;
                cliente.email = nuevoCliente.email;
                cliente.Estado = true;
                bd.Cliente.Add(cliente);
                bd.SaveChanges();
                return ConvertirClienteA_DTO(cliente);
            }
        }

        public List<ClienteRegistrado> ListarTodosLosClientes()
        {
            using(BodegaContextos bd = new BodegaContextos())
            {
                List<ClienteRegistrado> clientes = new List<ClienteRegistrado>();
                bd.Cliente.ToList().ForEach(x => clientes.Add(ConvertirClienteA_DTO(x)));
                return clientes;
            }
        }

        private ClienteRegistrado ConvertirClienteA_DTO(Cliente_ cliente)
        {
            ClienteRegistrado clienteRegistrado = new ClienteRegistrado();
            clienteRegistrado.Id = cliente.Id;
            clienteRegistrado.Nombre = cliente.Nombre;
            clienteRegistrado.Apellido = cliente.Apellido;
            clienteRegistrado.FechaNacimiento = cliente.FechaNacimiento;
            clienteRegistrado.Dni = cliente.Dni;
            clienteRegistrado.telefono = cliente.telefono;
            clienteRegistrado.email = cliente.email;
            clienteRegistrado.Estado = cliente.Estado;
            return clienteRegistrado;
        }

    }
}

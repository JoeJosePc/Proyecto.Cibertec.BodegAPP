using InterfacesBodegAPP.Clientes.Peticiones;
using InterfacesBodegAPP.Clientes.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBodegAPP.Clientes
{
    public interface IGestorDeClientes
    {
        ClienteRegistrado CrearCliente(NuevoCliente nuevoCliente);
        List<ClienteRegistrado> ListarTodosLosClientes();
        ClienteRegistrado ActualizarCliente(ClienteActualizado clienteActualizado);
        bool BorrarCliente(int ClienteID);
    }
}

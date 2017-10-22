using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBodegAPP.Clientes.Peticiones
{
    /// <summary>
    /// 
    /// </summary>
    public class NuevoCliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}

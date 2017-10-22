using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBodegAPP.Usuarios.Peticiones
{
    public class UsuarioActualizado
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Responsable { get; set; }
        public string Nivel { get; set; }
        public string Estado { get; set; }
        public DateTime FechaDeUltimaModificacion { get; set; }

        public UsuarioActualizado()
        {
            this.FechaDeUltimaModificacion = DateTime.Now;
        }
    }
}
